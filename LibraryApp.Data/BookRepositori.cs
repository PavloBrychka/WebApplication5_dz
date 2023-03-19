using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication5_dz;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp.Data
{
    public class BookRepositori : IBookRepositori
    {
        private readonly List<Book> _books;
        public BookRepositori()
        {
           
            _books = new List<Book>
            {
                new Book{Id=1,Title = "Book1",Author="NameAuthor1",Genere="Ganr1",Publisher="Publish", YearOfPublishing = 1888},
                new Book{Id=2,Title = "Book1",Author="NameAuthor1",Genere="Ganr1",Publisher="Publish", YearOfPublishing = 1888},
                new Book{Id=3,Title = "Book1",Author="NameAuthor1",Genere="Ganr1",Publisher="Publish", YearOfPublishing = 1888}
            };
        }

        

        public void AddBook(Book book)
        {
            book.Id= _books.Max(x => x.Id)+1;
            _books.Add(book);
        }

        public void DeleteBook(int id)
        {
           var book = _books.FirstOrDefault(x=> x.Id == id);
            if(book != null)
            {
                _books.Remove(book);
            }

        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if(existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Genere = book.Genere;
                existingBook.Publisher = book.Publisher;
                existingBook.YearOfPublishing = book.YearOfPublishing;
                
            }
        }
    }
}
