using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> bookLibrary = new Dictionary<string, Book>();
        public int Count { get { return bookLibrary.Count; } }


        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages);
            bookLibrary.TryAdd(book.title, book);
        }


        public Book Borrow(string title)
        {
            Book book = null;
            if(bookLibrary.TryGetValue(title, out book)) bookLibrary.Remove(title);
            return book;
        }
        public void Return(Book book)
        {
            bookLibrary.TryAdd(book.title, book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
