using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            labelColor.BackColor = Color.Blue;

            tbTh1.Text = th1.ToString();
            tbTh2.Text = th2.ToString();
            tbPer1.Text = per1.ToString();
            tbPer2.Text = per2.ToString();
            tbDepth.Text = 10.ToString();
            tbLength.Text = "100";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics ??= this.CreateGraphics();
            try
            {
                th1 = double.Parse(tbTh1.Text);
                th2 = double.Parse(tbTh2.Text);
                per1 = double.Parse(tbPer1.Text);
                per2 = double.Parse(tbPer2.Text);
                graphics.Clear(Color.White);
                button1.Enabled = false;
                drawCayleyTree(int.Parse(tbDepth.Text), 200, 310, int.Parse(tbLength.Text), -Math.PI / 2);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("请输入正确的数字格式!");
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if (n <= 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                new Pen(labelColor.BackColor),
                (int) x0, (int) y0, (int) x1, (int) y1);
        }

        private ColorDialog _colorDialog;

        private void labelColor_Click(object sender, EventArgs e)
        {
            _colorDialog ??= new ColorDialog()
            {
                Color =  labelColor.BackColor
            };
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelColor.BackColor = _colorDialog.Color;
            }
        }
    }
}