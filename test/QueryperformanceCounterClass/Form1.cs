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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double duration;

            duration = ids.FillCollection();
            textBox2.Text = duration.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double duration;
            
            duration = arrays.FillArray();
            textBox1.Text = duration.ToString();
            
        }
    }
}
