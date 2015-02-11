using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2K_DLL_AD.Hoofdstuk_2
{
    public partial class GradesForm : Form
    {
        int[] grades = { 12, 56, 89, 65, 61, 36, 45, 23 };
        public GradesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = grades.Max().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = grades.Average().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = grades.Min().ToString();
        }
    }
}