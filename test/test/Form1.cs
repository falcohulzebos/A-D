using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        Test test = new Test();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void turnInTest_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int number = Int32.Parse(numberBox.Text);
            test.addStudentTest(name, number);
            nameBox.Clear();
            numberBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.showStudents();
            textBox1.Text = test.students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
