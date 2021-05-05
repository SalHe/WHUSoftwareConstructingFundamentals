
namespace SearchEngine
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
            this.queryContent = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.searchResult2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queryContent
            // 
            this.queryContent.Location = new System.Drawing.Point(13, 12);
            this.queryContent.Name = "queryContent";
            this.queryContent.Size = new System.Drawing.Size(936, 27);
            this.queryContent.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(955, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(13, 47);
            this.searchResult.Multiline = true;
            this.searchResult.Name = "searchResult";
            this.searchResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchResult.Size = new System.Drawing.Size(515, 379);
            this.searchResult.TabIndex = 3;
            // 
            // searchResult2
            // 
            this.searchResult2.Location = new System.Drawing.Point(534, 47);
            this.searchResult2.Multiline = true;
            this.searchResult2.Name = "searchResult2";
            this.searchResult2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchResult2.Size = new System.Drawing.Size(515, 379);
            this.searchResult2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "百度";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchResult2);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.queryContent);
            this.Name = "MainForm";
            this.Text = "搜索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox queryContent;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.TextBox searchResult2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

