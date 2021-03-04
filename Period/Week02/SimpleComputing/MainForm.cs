using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleComputing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            var nums = LoadNumbersFromTextBox();
            if (nums == null) return;

            if (nums.Length <= 0) return;

            var max = nums[0];
            var min = nums[0];
            var sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]); // max = nums[i] > max ? nums[i] : max;
                min = Math.Min(min, nums[i]); // min = nums[i] < min ? nums[i] : min;
                sum += nums[i];
            }

            var ave = sum / nums.Length;

            tbMax.Text = max.ToString(CultureInfo.CurrentCulture);
            tbMin.Text = min.ToString(CultureInfo.CurrentCulture);
            tbSum.Text = sum.ToString(CultureInfo.CurrentCulture);
            tbAve.Text = ave.ToString(CultureInfo.CurrentCulture);
        }

        private double[] LoadNumbersFromTextBox()
        {
            double[] numbers = new double[tbNumArray.Lines.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!double.TryParse(tbNumArray.Lines[i], out numbers[i]))
                {
                    ReportParsingLineError(i);
                    return null;
                }
            }

            return numbers;
        }

        private void ReportParsingLineError(int lineNumber)
        {
            MessageBox.Show($"第{lineNumber + 1}行解析出错，请确定是否为一个有效的数字。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbSearchMin.Text, out var min))
            {
                MessageBox.Show("请使用整数作为最小值。", "查找素数", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbSearchMax.Text, out var max))
            {
                MessageBox.Show("请使用整数作为最大值。", "查找素数", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = 0;
            tbSearchResult.Text = "";
            for (int i = min; i <= max; i++)
            {
                if (IsPrimeNumber(i))
                {
                    tbSearchResult.AppendText(i.ToString());

                    count++;
                    tbSearchResult.AppendText(count % 10 == 0 ? "\r\n" : "\t");
                }
            }

            MessageBox.Show("搜索完毕！", "查找素数",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private static bool IsPrimeNumber(int num)
        {
            if (num <= 0)
                throw new ArgumentException("欲判断是否为素数的数不可为负数。");
            if (num <= 2)
                return true;
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(num)); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}