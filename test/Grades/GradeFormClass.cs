using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeFormClass
    {
        private Object thisLock = new Object();
        int[,] grades = new int [,] { { 10, 20, 30, 40 }, { 50, 60, 70, 80 } };
        int[] singleGrades = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        ArrayList AGrades = new ArrayList();
        QueryPerfCounter Q = new QueryPerfCounter();

        public GradeFormClass()
        {
            fillArrayList();
        }

        private void fillArrayList()
        {
            for (int i = 10; i < 100; i = i + 10)
            {
                AGrades.Add(i);
            }

        }

        public string max()
        {
            int max = 0;
            for (int i = 0; i < singleGrades.Length; i++)
            {
                if(singleGrades[i]> max)
                {
                    max = singleGrades[i];
                }
            }
                return "max: " + max;
        }

        public string min()
        {
            int min = 1111;
            for (int i = 0; i < singleGrades.Length; i++)
            {
                if (singleGrades[i] < min)
                {
                    min = singleGrades[i];
                }
            }
            return "min: " + min;
        }

        public string average()
        {
            int temp = 0;
            int average = 0;
            for (int i = 0; i < singleGrades.Length; i++)
            {
                
                
                    temp += singleGrades[i];
                
            }
            average = temp / singleGrades.Length;
            return "average: " + average;
        }

        public string multiMax()
        {
            string returnString = "";   
            int numberOfSubjects = grades.GetLength(0);
            int[] result = new int[numberOfSubjects];
            lock (thisLock)
            {
                
                for (int x = 0; x < numberOfSubjects; x++)
                {
                    int max = 0;
                    for (int y = 0; y < grades.GetLength(1); y++)
                    {
                        if (grades[x, y] > max)
                        {
                            max = grades[x, y];
                        }
                        result[x] = max;
                    }

                    returnString += "vak: " + x + " max: " + result[x] + "\r\n";
                }
                
            }

            return returnString; 
           
         }

        public string multiAverage()
         {
             string returnString = "";
             int numberOfSubjects = grades.GetLength(0);
             int[] result = new int[numberOfSubjects];
             lock (thisLock)
             {
                 for (int x = 0; x < numberOfSubjects; x++)
                 {
                     int avarage = 0;
                     for (int y = 0; y < grades.GetLength(1); y++)
                     {


                         avarage += grades[x, y];


                     }
                     result[x] = avarage / grades.GetLength(1);
                     returnString += "vak: " + x + " min: " + result[x] + "\r\n";
                 }
             }

             return returnString; 
         }

        public string multiMin()
        {
            string returnString = "";
            int numberOfSubjects = grades.GetLength(0);
            int[] result = new int[numberOfSubjects];
            lock (thisLock)
            {
                for (int x = 0; x < numberOfSubjects; x++)
                {
                    int min = 1111;
                    for (int y = 0; y < grades.GetLength(1); y++)
                    {
                        if (grades[x, y] < min)
                        {
                            min = grades[x, y];
                        }
                        result[x] = min;
                    }

                    returnString += "vak: " + x + " min: " + result[x] + "\r\n";
                }
            }


            return returnString; 
        }

        public string AMax()
        {

        }

        public string AMin()
        {

        }

    }
}
