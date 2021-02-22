using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Book
    {
        //field definition
        List<double> grades;
        public string Name;

        public Book(string name)
        {
        grades = new List<double>();
        this.Name = name;
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
            return Name;
        }
        
        public Statistics GetStats()
        {
            var res = new Statistics();
            res.Highest = double.MinValue;
            res.Lowest = double.MaxValue;
            var sum = 0.0;

            foreach (var grade in grades)
            {
                sum += grade;
                res.Highest = Math.Max(res.Highest, grade);
                res.Lowest = Math.Min(res.Lowest, grade);

            }
            res.Average = (sum / grades.Count);

            return res;
        
        }

        //public void ShowStats()
        //{

        //    Console.WriteLine($"The average grade is {average:N1}");
        //    Console.WriteLine($"The highest grade is {highest}");
        //    Console.WriteLine($"The lowest grade is {lowest}");
        //}

    }
}
