using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeFormClass
    {
        int[,] grades = new int [,] { { 10, 20, 30, 40 }, { 50, 60, 70, 80 } };
         
        public string Max()
        {
            string returnString = "";   
            int numberOfSubjects = grades.GetLength(0);
            int[] result = new int[numberOfSubjects];
            for(int x = 0; x < numberOfSubjects; x++)
            {
                int max = 0;
                for(int y = 0; y < grades.GetLength(1); y++)
                {
                    if(grades[x,y] > max)
                    {
                        max = grades[x, y];
                    }
                    result[x] = max;
                }
                
                returnString += "vak: " + x + " max: " + result[x];
             }


            return returnString; 
           
         }
        //public string Average()
        // {
        //     return grades[].Average().ToString();
        // }
        //public string Min()
        //{
        //    return grades[].Min().ToString();
        //}

    }
}
