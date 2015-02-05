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
            

       
        public string students;
        public string students2;
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


        public string searchTest(string name)
        {
            Student testToRemove=null;
            string returnText= "";
            foreach (Student tst in testPapers)
            {

                if (tst.getStudentName() == name)
                {
                    testPapersNew.Add(tst);

                    testToRemove = tst;

                    returnText = "student: " + tst.getStudentName() + " Met testnummer: " + tst.getTestNumber();
                   
                }

            }
            if (testToRemove != null)
            {
                testPapers.Remove(testToRemove);
            }
            return returnText;
        }
        public string showChecking()
        {
            string = ""; 
            foreach(Student checking in testPapersNew)
            {
                 string naam2 = checking.getStudentName();
                string nummer2 = checking.getTestNumber().ToString();
                students2 += "student: "+ naam2 + " Met testnummer: " + nummer2 + "\r\n";
                
            }
            return students2;
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
