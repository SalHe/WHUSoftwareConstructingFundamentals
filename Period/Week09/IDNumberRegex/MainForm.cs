using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDNumberRegex
{
    public partial class MainForm : Form
    {

        private readonly Regex validatorRegex = new Regex(@"^[\d]{10}(1[0-2]|0[0-9])([0-2][1-9]|10|20|30|31)\d{3}[\dXx]$");

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validatorRegex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("验证成功！", "验证", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("验证失败！", "验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
