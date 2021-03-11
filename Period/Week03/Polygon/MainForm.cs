using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon
{
    public partial class MainForm : Form
    {

        private Random random = new Random();

        private delegate IShape RandomShapeGenerator();

        private readonly IList<RandomShapeGenerator> generators;

        public MainForm()
        {
            InitializeComponent();

            generators = new List<RandomShapeGenerator>()
            {
                ()=>new Rectangle(){Width = random.NextDouble() * 15, Height = random.NextDouble() * 15},
                ()=>new Square(){Length= random.NextDouble() * 15},
                ()=>new Triangle(){A = random.NextDouble() * 15, B = random.NextDouble() * 15, C = random.NextDouble() * 15},
                ()=>new Circle(){radius = random.NextDouble() * 15}
            };

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCount.Text, out int count))
            {
                MessageBox.Show("请输入有效的整数！");
                return;
            }

            tbCount.Enabled  = btnGenerate.Enabled = false;
            progressBar1.Value = 0;
            progressBar1.Maximum = count;
            workerGenerate.RunWorkerAsync(count);
        }

        private void workerGenerate_DoWork(object sender, DoWorkEventArgs e)
        {
            var count =(int) e.Argument;
            for (int i = 0; i < count; i++)
            {
                var generator = generators[random.Next(0, generators.Count)];
                IShape shape = generator();
                // workerGenerate.ReportProgress((int)((double) (i + 1) / count * 100), shape);
                workerGenerate.ReportProgress(i, shape);
            }
        }

        private void workerGenerate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var shape = (IShape) e.UserState;

            progressBar1.Value = e.ProgressPercentage;

            tbResult.AppendText(shape.Description);
            tbResult.AppendText("\r\n");
        }

        private void workerGenerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbCount.Enabled = btnGenerate.Enabled = true;
        }
    }
}
