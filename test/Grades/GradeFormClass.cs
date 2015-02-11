using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeFormClass
    {
        int[] grades = { 12, 56, 89, 65, 61, 36, 45, 23 };
        int[] grades2 = { 99, 30, 10, 77, 45, 55, 67, 100 };
         public void Max()
         {
             grades.Max().ToString();
         }
        public void Average()
         {
             grades.Average().ToString();
         }
        public void Min()
        {
            grades.Min().ToString();
        }

    }
}
