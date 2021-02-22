using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Book
    {
        //field definition
        List<double> grades;
        string name; 
        public Book(string name)
        {
        grades = new List<double>();
        this.name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade>0 && grade <100) grades.Add(grade);
        }
        public List<double> GetGrades()
        {
            return grades;
        }
        public string GetName()
        {
            return name;
        }
        
        public void ShowStats()
        {
            var res = 0.0;
            var highest = double.MinValue;
            var lowest = double.MaxValue;
            foreach (var num in grades)
            {
                res += num;
                highest = Math.Max(highest, num);
                lowest = Math.Min(lowest, num);

            }
            Console.WriteLine($"The average grade is {(res / grades.Count):N1}");
            Console.WriteLine($"The highest grade is {highest}");
            Console.WriteLine($"The lowest grade is {lowest}");
        }

    }
}
