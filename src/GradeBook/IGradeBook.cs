using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    interface IGradeBook
    {
        void AddGrade(double grade);
        Statistics  GetStats();

         string Name { get; set; }

    }
}
