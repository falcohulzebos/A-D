using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeFormClass
    {
        int[,] grades = { { 10, 20 }, { 30, 40 }, { 50, 60 }, { 70, 80 } };
         public string Max()
         {
            return grades[].Max().ToString();
         }
        public string Average()
         {
             return grades[].Average().ToString();
         }
        public string Min()
        {
            return grades[].Min().ToString();
        }

    }
}
