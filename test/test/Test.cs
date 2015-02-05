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
        private ArrayList testPapars = new ArrayList();

        public void addStudentTest(string name, int number)
        {
            testPapars.Add(new Student(name, number));
        }
        
        public void showStudents()
        {
            foreach(object Student in testPapars)
            {
                Console.WriteLine(Student);
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
