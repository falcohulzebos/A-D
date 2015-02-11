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
    }
}