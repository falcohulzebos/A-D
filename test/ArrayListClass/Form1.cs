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
        ArrayList ItemList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            ItemList.Add("item4");
            ItemList.Add("Item5");
            ItemList.Add("Item2");
            ItemList.Add("Item1");
            ItemList.Add("Item3");
            for (i = 0; i <= ItemList.Count - 1; i++)
            {
                textBox1.Text = ItemList[i].ToString();
            }
        }

        //Insert an item
        public void Add()
        {
            ItemList.Insert();
        }

    }
}
