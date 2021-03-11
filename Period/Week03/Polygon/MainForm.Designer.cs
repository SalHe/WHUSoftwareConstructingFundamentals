
namespace Polygon
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.workerGenerate = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "图形个数：";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(95, 13);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(218, 27);
            this.tbCount.TabIndex = 1;
            this.tbCount.Text = "29";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(320, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 29);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(13, 54);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(905, 363);
            this.tbResult.TabIndex = 3;
            this.tbResult.WordWrap = false;
            // 
            // workerGenerate
            // 
            this.workerGenerate.WorkerReportsProgress = true;
            this.workerGenerate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerGenerate_DoWork);
            this.workerGenerate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerGenerate_ProgressChanged);
            this.workerGenerate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerGenerate_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(421, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(497, 29);
            this.progressBar1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 429);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbResult;
        private System.ComponentModel.BackgroundWorker workerGenerate;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

