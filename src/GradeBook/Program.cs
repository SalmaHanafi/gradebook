using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Salma's Grade Book");
      
            book.AddGrade(98.5);
            book.AddGrade(99.25);
            book.AddGrade(89.7);
            book.AddGrade(96.0);
            
            Console.WriteLine($"Summary for {book.GetName()}:");
            var stats = book.GetStats();

            Console.WriteLine($"the average grade is {stats.Average:n1}");
            Console.WriteLine($"the highest grade is {stats.Highest}");
            Console.WriteLine($"the lowest grade is {stats.Lowest}");
           
        }
    }
}
