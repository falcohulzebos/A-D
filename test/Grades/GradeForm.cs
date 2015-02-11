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
            textBox3.Text = g.Max();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //textBox3.Text = "Engels: " + g.Average() + "\r\nWiskunde: " + g.Average();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          //  textBox3.Text = "Engels: " + g.Min() + "\r\nWiskunde: " + g.Min();
        }
    }
}