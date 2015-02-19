using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryperformanceCounterClass
{
    public partial class Form1 : Form
    {
        Lijsten ids = new Lijsten();
        Lijsten arrays = new Lijsten();
        String output;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double duration;
            for (int i = 0; i < 5; i++)
            { 
                duration = ids.FillCollection();
            duration = duration / 1000;
            duration = Math.Round(duration, 0);
            output += duration.ToString() + "\r\n";
            }
            textBox2.Text = output;
            output = "";
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double duration;
            for (int i = 0; i < 5; i++)
            {
                duration = arrays.FillArray();
                duration = duration / 1000;
                duration = Math.Round(duration, 0);
                output += duration.ToString() + "\r\n";
            }
            textBox1.Text = output;
            output = "";
        }
    }
}
