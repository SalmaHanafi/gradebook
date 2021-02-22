using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        #region Reference Tests
        [Fact]
        public void GetBookReturnsDifferentObjectsTest()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        public Book GetBook(string name)
        {
            return new Book(name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObjecTest()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //Assert.Equal("Book 1", book1.Name);
            //Assert.Equal("Book 1", book2.Name);

            //Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void SettingBookNameFromReferenceTest()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        
        }

        private void SetName(Book book, string newName)
        {
            book.Name = newName;
        }


        [Fact]
        public void CSharpIsPassByValueTest()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string newName)
        {
            book = new Book(newName);
        }

        [Fact]
        public void CSharpCanPassByReferenceTest()
        {
            var book1 = GetBook("Book 1");
            SetReferencedName( ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void SetReferencedName(ref Book book, string newName)
        {
            book = new Book(newName);
        }

        #endregion

        #region Value Tests
        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42,x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void StringBehavesLikeValueTypesTest()
        {
            string name = "Salma";
            MakeUpperCase(name);

            Assert.Equal("Salma", name);
        }
        private void MakeUpperCase(string parameter)
        {
            parameter.ToUpper();
        }
        

        
        #endregion
    }
}
