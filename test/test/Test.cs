﻿using System;
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
        
        public void showStudents()
        {
            string students = ""; 
            foreach(object Student in testPapers)
            {
                students += Student.ToString() + "\r\n";
                
            }
            
        }


        public void searchTest(string name)
        {
            foreach (Student test in testPapers)
            {

                if (test.getStudentName() == name)
                {
                    testPapersNew.Add(test);
                    testPapers.Remove(test);
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
