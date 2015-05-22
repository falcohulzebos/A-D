using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
namespace DigitalWatchnew
{
    public partial class Form1 : Form
    {
        Watch watch = new Watch();
        private System.Timers.Timer timer;
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += (s, e) =>
            {
                this.SetText( watch.showTime());

            };
            timer.Start();
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label1.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watch.Switch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch.increment();
        }


    }
}
