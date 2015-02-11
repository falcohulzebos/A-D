using System;
using System.Linq;
using System.Windows.Forms;

namespace Grades
{
    public partial class GradeForm : Form
    {
        GradeFormClass g = new GradeFormClass();
        public GradeForm()
        {

            InitializeComponent();
            
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = g.multiMax();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = g.multiAverage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = g.multiMin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = g.min();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = g.average();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Text = g.max();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text = g.AMax();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text = g.AAverage();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = g.AMin();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox6.Text = g.getDuration().ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox7.Text= g.getDuration().ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            g.fillArray();
            g.fillArrayList();
            
        }


    }
}