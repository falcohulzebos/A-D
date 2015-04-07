using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DigitalWatch
{
    public partial class Form1 : Form
    {
        DigitalWatch dwatch;
        
        public Form1()
        {
            InitializeComponent();
           
            
            dwatch = new DigitalWatch();
            Thread timerthread = new Thread(new ThreadStart(watch));
            timerthread.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void watch()
        {
            while (true)
            {
                Thread.Sleep(100);
                textBox1.Text = dwatch.hours.ToString();
                textBox2.Text = dwatch.minutes.ToString();
            }
        }



    }
}
