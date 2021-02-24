using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public abstract class GradeBook : NamedObject, IGradeBook
    {
        public GradeBook(string name) : base(name)
        {
        }
        public abstract void AddGrade(double grade);

        public virtual Statistics GetStats()
        {
            throw new NotImplementedException();
        }
    }
}
