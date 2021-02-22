using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Salma's Grade Book");
            Console.WriteLine("Please Enter a grade or press q if you want to quit.");
            string input = Console.ReadLine();
            while (input != "q")
            {
                try { 
                    book.AddGrade(Double.Parse(input));
                    
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error!! {ex.Message}");
                    Console.ResetColor();
                }
                Console.WriteLine("Please Enter another grade or press q if you want to quit.");
                input = Console.ReadLine();
            }

            
            Console.WriteLine($"Summary for {book.GetName()}:");
            var stats = book.GetStats();

            Console.WriteLine($"The average grade is {stats.Average:n1}");
            Console.WriteLine($"The highest grade is {stats.Highest}");
            Console.WriteLine($"The lowest grade is {stats.Lowest}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
           
        }
    }
}
