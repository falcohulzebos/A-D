using System;
using System.Linq;
using System.Windows.Forms;

namespace Grades
{
    public partial class GradeForm : Form
    {
        int[] grades = { 12, 56, 89, 65, 61, 36, 45, 23 };
        int[] grades2 = { 99, 30, 10, 77, 45, 55, 67, 100 };
        public GradeForm()
        {
            InitializeComponent();
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = "Engels: " + grades.Max().ToString() + "\r\nWiskunde: " + grades2.Max().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Engels: " + grades.Average().ToString() + "\r\nWiskunde: " + grades2.Average().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Engels: " + grades.Min().ToString() + "\r\nWiskunde: " + grades2.Min().ToString();
        }
    }
}