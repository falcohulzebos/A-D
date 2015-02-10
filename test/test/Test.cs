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
        private ArrayList SubmittedTests = new ArrayList();
        private ArrayList outForChecking = new ArrayList();
       
        
        /// <summary>
        /// voeg een studentnaam en testnummer aan de stapel met tests toe
        /// </summary>
        /// <param name="name">studentnaam </param>
        /// <param name="number">testnummer</param>
        public void addStudentTest(string name, int number)
        {
            SubmittedTests.Add(new Student(name, number));
        }
        
        /// <summary>
        /// geef alle namen en testnummers weer die op de stapel zijn
        /// </summary>
        /// <returns>string met namen en testnummers</returns>
        public string showStudents()
        {
            students = ""; 
            foreach(Student testStudent in SubmittedTests)
            {
                string naam = testStudent.getStudentName();
                string nummer = testStudent.getTestNumber().ToString();
                students += "student: "+ naam + " Met testnummer: " + nummer + "\r\n";
                
            }
            return students;
            
        }

        /// <summary>
        /// zoekt een test op aan de hand van de naam en zet deze in outForChecking
        /// </summary>
        /// <param name="name">naam van de student</param>
        /// <returns>de naam en testnummer als deze gevonden is</returns>
        public string searchTest(string name)
        {
            Student testToRemove=null;
            string returnText= "";
            foreach (Student tst in SubmittedTests)
            {

                if (tst.getStudentName() == name)
                {
                    outForChecking.Add(tst);

                    testToRemove = tst;

                    returnText = "student: " + tst.getStudentName() + " Met testnummer: " + tst.getTestNumber();
                   
                }

            }
            if (testToRemove != null)
            {
                SubmittedTests.Remove(testToRemove);
            }
            return returnText;
        }

        /// <summary>
        /// geeft alle tests in outForChecking weer
        /// </summary>
        /// <returns>string met namen en testnummers</returns>
        public string showChecking()
        {
            students2 = ""; 
            foreach(Student checking in outForChecking)
            {
                 string naam2 = checking.getStudentName();
                string nummer2 = checking.getTestNumber().ToString();
                students2 += "student: "+ naam2 + " Met testnummer: " + nummer2 + "\r\n";
                
            }
            return students2;
            }

        /// <summary>
        /// zet alle tests die in outForChecking staan terug in
        /// Submittedtests en cleart outForChecking
        /// </summary>
        public void outForCheck()
        {
            foreach(Student s in outForChecking)
            {
                SubmittedTests.Add(s);
            }
            outForChecking.Clear();
        }
       
    }
    
    class Student
    {
        string studentName;
        int testNumber;
        /// <summary>
        /// maakt een Student object met studentnaam en testnummer
        /// </summary>
        /// <param name="studentName">de naam van de student</param>
        /// <param name="testNumber">het toetsnummer</param>
        public Student(string studentName, int testNumber)
        {
            this.studentName = studentName;
            this.testNumber = testNumber;

        }

        /// <summary>
        /// geeft de studentnaam 
        /// </summary>
        /// <returns>string met studentnaam</returns>
        public string getStudentName()
        {
            return studentName;
        }

        /// <summary>
        /// geeft het testnummer
        /// </summary>
        /// <returns>int testnummer</returns>
        public int getTestNumber()
        {
            return testNumber;
        }

       }
}
