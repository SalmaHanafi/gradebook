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
            book.ShowStats();

        }
    }
}
