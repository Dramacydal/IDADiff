using IDADiff.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDADiff
{
    public partial class MainForm : Form
    {
        class BoxWriter : TextWriter
        {
            public override Encoding Encoding { get { return Encoding.UTF8; } }

            protected TextBox TextBox { get; private set; }
            public BoxWriter(TextBox source)
            {
                TextBox = source;
            }

            public override void Write(string value)
            {
                TextBox.Text += value;
            }

            public override void WriteLine(string value)
            {
                TextBox.Text += value + NewLine;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            Console.SetOut(new BoxWriter(logTextBox));
        }

        private void browseDiffButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "IDA DIF File (*.dif)|*.dif|All Files (*.*)|*.*";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            diffTextBox.Text = dialog.FileName;
        }

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            inputTextBox.Text = dialog.FileName;
            outputTextBox.Text = Path.Combine(
                Path.GetDirectoryName(dialog.FileName),
                Path.GetFileNameWithoutExtension(dialog.FileName) + "_patched" + Path.GetExtension(dialog.FileName));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            if (File.Exists(inputTextBox.Text))
            {
                dialog.DefaultExt = Path.GetExtension(inputTextBox.Text);
                dialog.AddExtension = true;
            }
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;
            outputTextBox.Text = dialog.FileName;
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var patchInfo = DiffLoader.LoadDiff(diffTextBox.Text);
                Patcher.Patch(inputTextBox.Text, outputTextBox.Text, patchInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
