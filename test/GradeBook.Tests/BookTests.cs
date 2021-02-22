 using System;
using Xunit;
using GradeBook;

namespace GradeBook.Tests  
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            
            //arrange
            var book = new Book("");
            book.AddGrade(98.3);
            book.AddGrade(85.4);
            book.AddGrade(90.6);

            //act
             var stats = book.GetStats();

            Assert.Equal(98.3,stats.Highest);
            Assert.Equal(85.4, stats.Lowest);
            Assert.Equal(91, stats.Average,0);
        }
    }
}
