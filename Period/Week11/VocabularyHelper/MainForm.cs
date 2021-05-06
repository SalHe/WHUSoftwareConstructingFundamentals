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
using Microsoft.EntityFrameworkCore;

namespace VocabularyHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();

            // 绑定数据
            BindDataSource();
        }

        private void BindDataSource()
        {
            using (var db = new WordContext())
            {
                db.Words.Load();
                dataGridView1.DataSource = db.Words.Local.ToBindingList();
            }
        }

        private void InitializeDatabase()
        {
            using (var wordContext = new WordContext())
            {
                wordContext.Database.EnsureCreated();

                if (wordContext.Words.Count() == 0)
                {
                    wordContext.Words.Add(new Word
                    {
                        Id = 1,
                        English = "apple",
                        Chinese = "苹果"
                    });
                    wordContext.Words.Add(new Word
                    {
                        Id = 2,
                        English = "banana",
                        Chinese = "香蕉"
                    });
                    wordContext.SaveChanges();
                }
            }
        }

        private void findWordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(English.Text) && string.IsNullOrWhiteSpace(Chinese.Text))
            {
                MessageBox.Show("请至少输入有效的中文或英文");
                return;
            }
            using (var wordContext = new WordContext())
            {
                bool found = wordContext.Words.Any(word =>
                        (string.IsNullOrWhiteSpace(English.Text) || English.Text.Equals(word.English))
                    && (string.IsNullOrWhiteSpace(Chinese.Text) || Chinese.Text.Equals(word.Chinese)));
                if (found)
                {
                    MessageBox.Show("单词正确！");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Chinese.Text))
                    {
                        MessageBox.Show("不存在这个英文单词！");
                    }
                    else if (string.IsNullOrWhiteSpace(English.Text))
                    {
                        MessageBox.Show("不存在单词具备这个中文含义！");
                    }
                    else
                    {
                        MessageBox.Show("单词错误！");
                    }
                }
            }
        }

        private void addWordBtn_Click(object sender, EventArgs args)
        {
            if (string.IsNullOrWhiteSpace(English.Text) || string.IsNullOrWhiteSpace(Chinese.Text))
            {
                MessageBox.Show("请填写完整的单词信息！");
                return;
            }

            using (var wordContext = new WordContext())
            {
                try
                {
                    wordContext.Words.Add(new Word
                    {
                        Id = wordContext.Words.Count() + 1,
                        English = English.Text,
                        Chinese = Chinese.Text
                    });
                    wordContext.SaveChanges();
                    BindDataSource();
                }
                catch (DbUpdateException e)
                {
                    MessageBox.Show($"添加单词出错！错误信息：\n\n{e}");
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show($"添加单词出错！错误信息：\n\n{e}");
                }
            }
        }
    }
}
