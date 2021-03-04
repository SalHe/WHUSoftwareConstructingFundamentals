
namespace SimpleComputing
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.tbNumArray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSearchResult = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAve);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.tbNumArray);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第 1 题";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(307, 215);
            this.tbSum.Name = "tbSum";
            this.tbSum.ReadOnly = true;
            this.tbSum.Size = new System.Drawing.Size(44, 27);
            this.tbSum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "和：";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(191, 215);
            this.tbMin.Name = "tbMin";
            this.tbMin.ReadOnly = true;
            this.tbMin.Size = new System.Drawing.Size(44, 27);
            this.tbMin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "最小值：";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(71, 215);
            this.tbMax.Name = "tbMax";
            this.tbMax.ReadOnly = true;
            this.tbMax.Size = new System.Drawing.Size(44, 27);
            this.tbMax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "最大值：";
            // 
            // tbAve
            // 
            this.tbAve.Location = new System.Drawing.Point(425, 215);
            this.tbAve.Name = "tbAve";
            this.tbAve.ReadOnly = true;
            this.tbAve.Size = new System.Drawing.Size(44, 27);
            this.tbAve.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "平均值：";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(683, 215);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(94, 29);
            this.btnCompute.TabIndex = 3;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // tbNumArray
            // 
            this.tbNumArray.Location = new System.Drawing.Point(7, 87);
            this.tbNumArray.Multiline = true;
            this.tbNumArray.Name = "tbNumArray";
            this.tbNumArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNumArray.Size = new System.Drawing.Size(770, 122);
            this.tbNumArray.TabIndex = 2;
            this.tbNumArray.Text = "5\r\n3\r\n1\r\n2\r\n4\r\n8\r\n9\r\n10\r\n6\r\n7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "数组元素(一行一个元素)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. 编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearchResult);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tbSearchMax);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSearchMin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第 2 题";
            // 
            // tbSearchResult
            // 
            this.tbSearchResult.Location = new System.Drawing.Point(6, 120);
            this.tbSearchResult.Multiline = true;
            this.tbSearchResult.Name = "tbSearchResult";
            this.tbSearchResult.ReadOnly = true;
            this.tbSearchResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSearchResult.Size = new System.Drawing.Size(771, 160);
            this.tbSearchResult.TabIndex = 7;
            this.tbSearchResult.Text = "输入最大最小值，然后开始寻找素数试试叭~\r\n\r\n（表示我的电脑使用VS+Win Form特别卡。\r\n不知道是不是因为是AMD CPU + 不使用核显的原因，想写控" +
    "制台程序了。。）";
            this.tbSearchResult.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "开始寻找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchMax
            // 
            this.tbSearchMax.Location = new System.Drawing.Point(220, 85);
            this.tbSearchMax.Name = "tbSearchMax";
            this.tbSearchMax.Size = new System.Drawing.Size(75, 27);
            this.tbSearchMax.TabIndex = 5;
            this.tbSearchMax.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "最大值：";
            // 
            // tbSearchMin
            // 
            this.tbSearchMin.Location = new System.Drawing.Point(71, 85);
            this.tbSearchMin.Name = "tbSearchMin";
            this.tbSearchMin.Size = new System.Drawing.Size(75, 27);
            this.tbSearchMin.TabIndex = 3;
            this.tbSearchMin.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "最小值：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(629, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "2. 编写程序，接收用户输入的两个数据为上下限，然后10个一行输出上下限之间的所有素数。";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课堂练习 - 第二周";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox tbNumArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearchMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSearchResult;
        private System.Windows.Forms.Button btnSearch;
    }
}

