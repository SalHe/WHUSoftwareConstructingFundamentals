using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateTime = System.DateTime;

namespace Alarm
{
    public partial class MainForm : Form
    {

        private Dictionary<CheckBox, EventHandler> eventHandlers;

        private KeyValuePair<int, int> alarmTime;
        private bool alarmed = false;

        public MainForm()
        {
            InitializeComponent();

            // 不同的 CheckBox 对应了其相应的 Event
            // 我们在此处为他们的关系建立字典
            // 方便后面使用
            eventHandlers = new Dictionary<CheckBox, EventHandler>
            {
                [cbTick] = eventTick,
                [cbAlarm] = eventAlarm
            };

            // 让所有的 CheckBox 默认都选中
            foreach (var entry in eventHandlers)
            {
                entry.Key.Checked = true;
            }

            // 让闹钟时间为下一分钟
            dateTimePicker1.Value = DateTime.Now + TimeSpan.FromMinutes(1);

            // 调整 Picker 的时间格式
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
        }

        private void checkBoxToEnableEvent_CheckedChanged(object sender, EventArgs e)
        {
            // 两个CheckBox的CheckedChanged事件都被此函数注册了
            // 所以下面会根据 sender 的不同，注册/取消注册相应的事件
            if (sender is CheckBox c)
            {
                if (c.Checked)
                    timer1.Tick += eventHandlers[c];
                else
                    timer1.Tick -= eventHandlers[c];
            }
        }

        private void eventTick(object sender, EventArgs e)
        {
            tbTick.Text = "Tick" + DateTime.Now.ToLongTimeString();
            Console.Beep();
        }

        private void eventAlarm(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            labelAlarm.Text = "Alarm" + now.ToLongTimeString();
            if (now.Hour == alarmTime.Key && now.Minute == alarmTime.Value && !alarmed)
            {
                alarmed = true;
                MessageBox.Show($"您{alarmTime.Key:D2}:{alarmTime.Value:D2}的闹钟已经到了哦~~");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            alarmTime = new KeyValuePair<int, int>(dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute);
            alarmed = false;
        }
    }
}
