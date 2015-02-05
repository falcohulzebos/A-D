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
            

        private string studentName;
        private int testNumber;
        public string students;
        private ArrayList testPapers = new ArrayList();
        private ArrayList testPapersNew = new ArrayList();

        public void addStudentTest(string name, int number)
        {
            testPapers.Add(new Student(name, number));
        }
        
        public string showStudents()
        {
            students = ""; 
            foreach(Student testStudent in testPapers)
            {
                string naam = testStudent.getStudentName();
                string nummer = testStudent.getTestNumber().ToString();
                students += "student: "+ naam + " Met testnummer: " + nummer + "\r\n";
                
            }
            return students;
            
        }


        public void searchTest(string name)
        {
            foreach (Student tst in testPapers)
            {

                if (tst.getStudentName() == name)
                {
                    testPapersNew.Add(tst);
                    testPapers.Remove(tst);
                    studentName = tst.getStudentName();
                    testNumber = tst.getTestNumber();
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
