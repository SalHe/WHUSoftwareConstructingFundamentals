
namespace VocabularyHelper
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.English = new System.Windows.Forms.TextBox();
            this.Chinese = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findWordBtn = new System.Windows.Forms.Button();
            this.addWordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(472, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "英文";
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(57, 294);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(125, 27);
            this.English.TabIndex = 2;
            // 
            // Chinese
            // 
            this.Chinese.Location = new System.Drawing.Point(232, 293);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(125, 27);
            this.Chinese.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "中文";
            // 
            // findWordBtn
            // 
            this.findWordBtn.Location = new System.Drawing.Point(395, 326);
            this.findWordBtn.Name = "findWordBtn";
            this.findWordBtn.Size = new System.Drawing.Size(94, 29);
            this.findWordBtn.TabIndex = 5;
            this.findWordBtn.Text = "查找/对比";
            this.findWordBtn.UseVisualStyleBackColor = true;
            this.findWordBtn.Click += new System.EventHandler(this.findWordBtn_Click);
            // 
            // addWordBtn
            // 
            this.addWordBtn.Location = new System.Drawing.Point(295, 326);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(94, 29);
            this.addWordBtn.TabIndex = 6;
            this.addWordBtn.Text = "添加单词";
            this.addWordBtn.UseVisualStyleBackColor = true;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 367);
            this.Controls.Add(this.addWordBtn);
            this.Controls.Add(this.findWordBtn);
            this.Controls.Add(this.Chinese);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.English);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单词小助手";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox English;
        private System.Windows.Forms.TextBox Chinese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findWordBtn;
        private System.Windows.Forms.Button addWordBtn;
    }
}

