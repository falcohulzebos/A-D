using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace INF2K_DLL_AD.Hoofdstuk_2
{
    class GradeTracker
    {
        int[] grades= { 12, 56, 89, 65, 61, 36, 45, 23 };

        public void getMaxGrade()
        {
            int max = grades.Max();
        }

        public void getMinGrade()
        {
            int min = grades.Min();
        }

        public void getAverageGrade()
        {
            double average = grades.Average();
        }
    }
}
