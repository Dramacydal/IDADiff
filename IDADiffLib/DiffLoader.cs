using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IDADiff.Lib
{
    public class PatchInfo
    {
        public int Offset { get; set; }
        public byte Old { get; set; }
        public byte New { get; set; }
    }

    public class DiffLoader
    {
        public static IEnumerable<PatchInfo> LoadDiff(string path)
        {
            if (!File.Exists(path))
                throw new IDADiffException("No such file: " + path);

            var infos = new List<PatchInfo>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var match = Regex.Match(line, @"(\w+): (\w+) (\w+)");
                if (match.Groups.Count > 1)
                {
                    var info = new PatchInfo
                    {
                        Offset = Convert.ToInt32(match.Groups[1].Value, 16),
                        Old = Convert.ToByte(match.Groups[2].Value, 16),
                        New = Convert.ToByte(match.Groups[3].Value, 16)
                    };
                    infos.Add(info);
                }
            }

            Console.WriteLine("Loaded patches:");
            foreach (var info in infos)
                Console.WriteLine("0x{0:x}: 0x{1:X} -> 0x{2:X}", info.Offset, info.Old, info.New);

            return infos;
        }
    }
}
