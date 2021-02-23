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
        //public string Name;
        public string Name { get; set; }

        public Book(string name)
        {
        grades = new List<double>();
        this.Name = name;
        }
      
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100) grades.Add(grade);
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}!");

            }
        }
        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90.0);
                    break;
                case 'B':
                    AddGrade(80.0);
                    break;
                case 'C':
                    AddGrade(70.0);
                    break;
                default:
                    AddGrade(0.0);
                    break;

            }

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

            for(var i =0; i<grades.Count; i++)
            {
                //if(grades[i] < 49.5)
                //{
                //    continue;
                //}
                sum += grades[i];
                res.Highest = Math.Max(res.Highest, grades[i]);
                res.Lowest = Math.Min(res.Lowest, grades[i]);
          
            }

            res.Average = (sum / grades.Count);
            switch (res.Average)
            {
                case var d when d >= 90.0:
                    res.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    res.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    res.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    res.Letter = 'D';
                    break;
                default:
                    res.Letter = 'F';
                    break;
            }

            return res;
        
        }

    }
}
