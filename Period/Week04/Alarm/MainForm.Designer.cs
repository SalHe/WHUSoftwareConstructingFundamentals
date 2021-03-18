
namespace Alarm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbTick = new System.Windows.Forms.CheckBox();
            this.cbAlarm = new System.Windows.Forms.CheckBox();
            this.tbTick = new System.Windows.Forms.TextBox();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // cbTick
            // 
            this.cbTick.AutoSize = true;
            this.cbTick.Location = new System.Drawing.Point(15, 235);
            this.cbTick.Name = "cbTick";
            this.cbTick.Size = new System.Drawing.Size(90, 24);
            this.cbTick.TabIndex = 0;
            this.cbTick.Text = "启用Tick";
            this.cbTick.UseVisualStyleBackColor = true;
            this.cbTick.CheckedChanged += new System.EventHandler(this.checkBoxToEnableEvent_CheckedChanged);
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoSize = true;
            this.cbAlarm.Location = new System.Drawing.Point(15, 269);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(104, 24);
            this.cbAlarm.TabIndex = 1;
            this.cbAlarm.Text = "启用Alarm";
            this.cbAlarm.UseVisualStyleBackColor = true;
            this.cbAlarm.CheckedChanged += new System.EventHandler(this.checkBoxToEnableEvent_CheckedChanged);
            // 
            // tbTick
            // 
            this.tbTick.Location = new System.Drawing.Point(121, 235);
            this.tbTick.Name = "tbTick";
            this.tbTick.ReadOnly = true;
            this.tbTick.Size = new System.Drawing.Size(249, 27);
            this.tbTick.TabIndex = 2;
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.Location = new System.Drawing.Point(121, 269);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(0, 20);
            this.labelAlarm.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 216);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 202);
            this.label2.TabIndex = 0;
            this.label2.Text = "题目：\r\n使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台/Winform界面上显" +
    "示提示信息。\r\n\r\n说明：\r\n当启用Tick时，将在TextBox内显示时间，并每秒发出鸣叫声；当启用Alarm时，将在Label内显示时间，并会在指定的时间弹" +
    "出提示。";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 299);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 336);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelAlarm);
            this.Controls.Add(this.tbTick);
            this.Controls.Add(this.cbAlarm);
            this.Controls.Add(this.cbTick);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⏰闹钟";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbTick;
        private System.Windows.Forms.CheckBox cbAlarm;
        private System.Windows.Forms.TextBox tbTick;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

