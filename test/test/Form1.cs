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

        /// <summary>
        /// haalt de naam en testnummer uit de textvelden
        /// en roept sddStudentTest aan om de test toe te voegen
        /// aan submittedTests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void turnInTest_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int number = Int32.Parse(numberBox.Text);
            test.addStudentTest(name, number);
            nameBox.Clear();
            numberBox.Clear();
        }

        /// <summary>
        /// roept showStudents aan om de test weer te geven in textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            test.showStudents();
            textBox1.Text = test.students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// roept searchTest aan 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            
            string searchName = searchNameBox.Text;
            
            textBox1.Text = test.searchTest(searchName);
            test.showStudents();
        }

        /// <summary>
        /// geeft alle outForChecking test weer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            test.showChecking();
            textBox2.Text = test.students2;
        }

        /// <summary>
        /// zet alle tests terug in submittedtestes 
        /// en cleart outForChecking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            test.outForCheck();
        }


    }
}
