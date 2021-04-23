using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            try
            {

                if (CheckIDNumber(textBox1.Text))
                {
                    MessageBox.Show("验证成功！", "验证", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIDNumber(string ID)
        {
            if (validatorRegex.IsMatch(textBox1.Text))
            {
                int sum = 0;
                for (int i = 0; i < 17; i++)
                {
                    int a = ID[i] - '0';
                    int w = (int)Math.Pow(2, 17 - i) % 11;
                    Debug.WriteLine($"{a} * {w}");
                    sum += a * w;
                }
                int final = 12 - sum % 11;
                char last = (char)(final < 10 ? ('0' + final) : 'x');
                if (char.ToLower(ID[17]) == last)
                    return true;
                else
                    throw new ArgumentException("校验码有误！");
            }
            throw new ArgumentException("身份证格式错误！");
        }
    }
}
