﻿using System;
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
        private Object thisLock = new Object();
        Lijsten arrays = new Lijsten();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lock (thisLock)
            {
                arrays.FillArray();
            }
        }
    }
}
