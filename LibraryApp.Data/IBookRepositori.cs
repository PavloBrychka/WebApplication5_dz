using WebApplication5_dz;

namespace LibraryApp.Data
{
    public interface IBookRepositori
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}