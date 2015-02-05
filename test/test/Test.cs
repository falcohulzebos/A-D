using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace TestForm
{

    class Test
    {
        private ArrayList testPapersNew = new ArrayList;    

        private string studentName;
        private int testNumber;
        private ArrayList testPapars = new ArrayList();

        public void addStudentTest(string name, int number)
        {
            testPapars.Add(new Student(name, number));
        }
        
        public void showStudents()
        {
            string students = ""; 
            foreach(object Student in testPapars)
            {
                students += Student.ToString() + "\r\n";
            }
            
        }


        public void searchTest(string name)
        {
            foreach (Student test in testPapars)
            {

                if (test.getStudentName() == name)
                {
                    testPapersNew.Add(test);
                    testPapars.Remove(test);
                    studentName = test.getStudentName();
                    testNumber = test.getTestNumber();
                }
            }
        }

    }
    
    class Student
    {
        string studentName;
        int testNumber;

        public Student(string studentName, int testNumber)
        {
            this.studentName = studentName;
            this.testNumber = testNumber;

        }

        public string getStudentName()
        {
            return studentName;
        }

        public int getTestNumber()
        {
            return testNumber;
        }

    }
}
