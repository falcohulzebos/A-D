using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListClass
{
    public partial class Form1 : Form
    {
        ArrayListClass<int> array = new ArrayListClass<int>();

        public Form1()
        {
            InitializeComponent();
        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10 ; i++)
            {
                array.Add(i);
            }

            
            
        }


       
    }
}
