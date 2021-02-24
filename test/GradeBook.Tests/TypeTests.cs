using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string LogMessage);
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

        public InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
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

        private void SetName(InMemoryBook book, string newName)
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

        private void GetBookSetName(InMemoryBook book, string newName)
        {
            book = new InMemoryBook(newName);
        }

        [Fact]
        public void CSharpCanPassByReferenceTest()
        {
            var book1 = GetBook("Book 1");
            SetReferencedName( ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void SetReferencedName(ref InMemoryBook book, string newName)
        {
            book = new InMemoryBook(newName);
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

        #region Delegate Tests
        int count = 0;
        [Fact]
        public void WriteLogDelegatePointsToMethodTest()
        {
            WriteLogDelegate log = getMessage;
            log += getAnotherMessage;

            var res = log("Log Message!");

            Assert.Equal("log message!", res );
            Assert.Equal(2, count);
        }

        //for testing  WriteLogDelegatePointsToMethodTest
        string getMessage(string message)
        {
            count++;
            return message.ToUpper();
        }
        string getAnotherMessage(string message2)
        {
            count++;
            return message2.ToLower();
        }
        #endregion
    }
}
