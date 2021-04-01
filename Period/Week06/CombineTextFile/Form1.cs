using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombineTextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectOneTextFile(textBox1);
        }

        private void SelectOneTextFile(TextBox textBox)
        {
            var file = SelectOneTextFile();
            if (file != null)
                textBox.Text = file;
        }

        private string SelectOneTextFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                AddExtension = true,
                Filter = "Text Files(*.txt)|*.txt|All Files|*.*"
            };
            var result = fileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                return fileDialog.FileName;
            }

            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectOneTextFile(textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] fileNames = {textBox1.Text, textBox2.Text};
            string outDir = Path.Combine(Directory.GetCurrentDirectory(), "Data");
            if (!Directory.Exists(outDir))
            {
                try
                {
                    Directory.CreateDirectory(outDir);
                }
                catch (Exception)
                {
                    MessageBox.Show("无法创建Data目录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
                
            int i = 0;
            string outFile;
            while (true)
            {
                outFile = Path.Combine(outDir, $"merged{i}.txt");
                if(!File.Exists(outFile))
                    break;
                i++;
            }
            try
            {
                MergeTextFilesTo(outFile, fileNames);
            }
            catch (Exception)
            {
                MessageBox.Show("合并失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"合并成功！文件已保存到：{outFile}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MergeTextFilesTo(string outFile, string[] inFiles)
        {
            using var os = File.OpenWrite(outFile);
            using var writer = new StreamWriter(os);
            foreach (string inFile in inFiles)
            {
                writer.Write(File.ReadAllText(inFile, Encoding.UTF8));
            }
            writer.Flush();
        }
    }
}
