using System;
using Xunit;
using Books;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Library lib = new Library();
            lib.Add("Book1", "Ahmad", "Mohmmad", 542);
            lib.Add("Book2", "Ahmad", "Mohmmad", 623);
            lib.Add("Book3", "Ahmad", "Mohmmad", 204);
            Assert.Equal(3, lib.Count);
        }

        [Fact]
        public void BorrowTest()
        {
            Library lib = new Library();
            lib.Add("Book1", "Ahmad", "Mohmmad", 542);
            lib.Add("Book2", "Ahmad", "Mohmmad", 623);
            lib.Add("Book3", "Ahmad", "Mohmmad", 204);
            Book book = lib.Borrow("Book2");
            Assert.Equal("Book2", book.title);
            Assert.Equal(2, lib.Count);
            
        }

        [Fact]
        public void BorrowMissingTest()
        {
            Library lib = new Library();
            lib.Add("Book1", "Ahmad", "Mohmmad", 542);
            lib.Add("Book2", "Ahmad", "Mohmmad", 623);
            lib.Add("Book3", "Ahmad", "Mohmmad", 204);
            Book book = lib.Borrow("Book5");
            Assert.Null(book);
            Assert.Equal(3, lib.Count);
        }

        [Fact]
        public void ReturnBookTest()
        {
            Library lib = new Library();
            lib.Add("Book1", "Ahmad", "Mohmmad", 542);
            lib.Add("Book2", "Ahmad", "Mohmmad", 623);
            lib.Add("Book3", "Ahmad", "Mohmmad", 204);
            Book book = new Book("Book4", "Ahmad", "Mohmmad", 245);
            lib.Return(book);
            Assert.Equal(4, lib.Count);
        }

        [Fact]
        public void BackpackTest()
        {
            Book book1 = new Book("Book1", "Ahmad", "Mohmmad", 245);
            Book book2 = new Book("Book2", "Ahmad", "Mohmmad", 452);
            Backpack<Book> backPack = new Backpack<Book>();
            Assert.Equal(0, backPack.Count);
            backPack.Pack(book1);
            Assert.Equal(1, backPack.Count);
            backPack.Pack(book2);
            Assert.Equal(2, backPack.Count);
            Book book = backPack.Unpack(0);
            Assert.Equal(1, backPack.Count);
            Assert.Equal("Book1", book.title);
        }
    }
}
