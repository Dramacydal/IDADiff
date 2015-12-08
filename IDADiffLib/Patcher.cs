using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDADiff.Lib
{
    public static class Patcher
    {
        public static void Patch(string input, string output, IEnumerable<PatchInfo> patches)
        {
            if (!File.Exists(input))
                throw new IDADiffException("No such file: " + input);

            if (!Directory.Exists(Path.GetDirectoryName(output)))
                throw new IDADiffException("No such output directory: " + Path.GetDirectoryName(output));

            if (patches.Count() == 0)
                throw new IDADiffException("Nothing to patch");

            using (var m = new MemoryStream(File.ReadAllBytes(input)))
            using (var r = new BinaryReader(m))
            using (var w = new BinaryWriter(m))
            {
                foreach (var patch in patches)
                {
                    r.BaseStream.Seek(patch.Offset, SeekOrigin.Begin);
                    var b = r.ReadByte();
                    if (b != patch.Old)
                        throw new IDADiffException(string.Format("Input file does not match diff at 0x{0:X}: 0x{1:X} should be 0x{2:X}", patch.Offset, b, patch.Old));

                    w.Seek(patch.Offset, SeekOrigin.Begin);
                    w.Write(patch.New);
                }

                File.WriteAllBytes(output, m.ToArray());
            }
        }
    }
}
