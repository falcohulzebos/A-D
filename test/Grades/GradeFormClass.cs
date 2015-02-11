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
        int[] singleGrades = new int[10000];
        ArrayList AGrades = new ArrayList();
        QueryPerfCounter Q = new QueryPerfCounter();
        private double duration;
        


        public void fillArray()
        {


            for (int i = 1; i < 5;  i++)
                {
                    for (int a = 0; a < 100; a++)
                    {

                        singleGrades[i] = a;
                        Console.WriteLine(i + " - - - " + a + " - - - " + "fillarray");

                    }
                }
            

        }

        public void fillArrayList()
        {

           
                for (int i = 0; i < 5;  i++)
                {
                    for (int a = 0; a < 100; a++)
                    {
                        AGrades.Add(a);
                        Console.WriteLine(i + " - - - " + a + " - - - " + "fillarraylist");
                    }
                
            }
        }

       

        public string max()
        {
            int max = 0;
            lock (thisLock)
            {
                Q.Start();
                for (int i = 0; i < singleGrades.Length; i++)
                {
                    if (singleGrades[i] > max)
                    {
                        max = singleGrades[i];
                    }
                }
                Q.Stop();
            }
          duration = Q.Duration(1);
                return "max: " + max;
        }

        public string min()
        {
            int min = 1111;
            lock (thisLock)
            {
                Q.Start();
                for (int i = 0; i < singleGrades.Length; i++)
                {
                    if (singleGrades[i] < min)
                    {
                        min = singleGrades[i];
                    }
                }
                Q.Stop();
            }
            duration = Q.Duration(1);
            return "min: " + min;
        }

        public string average()
        {
            int temp = 0;
            double average = 0;
            lock (thisLock)
            {
                Q.Start();
                for (int i = 0; i < singleGrades.Length; i++)
                {


                    temp += singleGrades[i];

                }
                average = temp / singleGrades.Length;
                Console.WriteLine(temp);
                Console.WriteLine(singleGrades.Length);
                Q.Stop();
            }
            duration = Q.Duration(1);
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
            int max = 0;
            lock (thisLock)
            {
                Q.Start();
                foreach (int i in AGrades)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                Q.Stop();
            }
            duration = Q.Duration(1);
            return "max: " + max;
        }

        public string AMin()
        {
            int min = 1000;
            lock (thisLock)
            {
                Q.Start();
                foreach (int i in AGrades)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                Q.Stop();
            }
            duration = Q.Duration(1);
            return "min: " + min;
        }

        public string AAverage()
        {
            int temp = 0;
            double average = 0;
            lock (thisLock)
            {
                Q.Start();
                foreach (int i in AGrades)
                {

                    temp += i;

                }
                average = temp / AGrades.Count;
                Q.Stop();
            }
            duration = Q.Duration(1);
            return "average: " + average;

        }

        public double getDuration()
        {
            return duration;
        }

    }
}
