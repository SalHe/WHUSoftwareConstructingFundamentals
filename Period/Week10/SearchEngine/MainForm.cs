using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchEngine.Engine;

namespace SearchEngine
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            searchButton.Enabled = false;
            if (string.IsNullOrEmpty(queryContent.Text))
            {
                MessageBox.Show("搜索内容不能为空");
                searchButton.Enabled = true;
                return;
            }

            Semaphore semaphore = new Semaphore(0, 2);

            Thread th1 = new Thread(async () =>
            {
                await Search(Baidu.Default, searchResult);
                semaphore.Release();
            });
            Thread th2 = new Thread(async () =>
            {
                await Search(Bing.Default, searchResult2);
                semaphore.Release();
            });
            th1.Start();
            th2.Start();

            new Thread(() =>
            {
                semaphore.WaitOne();
                semaphore.WaitOne();
                searchButton.Invoke(new Action(() => searchButton.Enabled = true));
            }).Start();
        }

        private async Task Search(ISearchEngine currentEngine, TextBox resultTo)
        {
            UpdateTextBox(resultTo, $"正在从{currentEngine.Name}搜素...");
            IList<SearchResult> searchResults = await currentEngine.SearchAsync(queryContent.Text);

            if (searchResults.Count == 0)
            {
                UpdateTextBox(resultTo, "未搜索到结果，您可以选择重试.");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (var result in searchResults)
                {
                    sb.AppendLine("-------------------------------");
                    sb.AppendLine(result.URL);
                    if (result.Preview.Length > 200)
                    {
                        sb.AppendLine(result.Preview.Substring(0, 200) + "...");
                    }
                    else
                    {
                        sb.AppendLine(result.Preview);
                    }
                    sb.AppendLine();
                }
                UpdateTextBox(resultTo, sb.ToString());
            }
        }

        private void UpdateTextBox(TextBox tb, string content)
        {
            tb.Invoke(new Action(()=>tb.Text = content));
        }
    }
}
