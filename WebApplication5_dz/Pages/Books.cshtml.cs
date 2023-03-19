using LibraryApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication5_dz.Pages
{
    public class BooksModel : PageModel
    {

        public IEnumerable<Book> Books;

        private readonly IBookRepositori _bookRepositori;

        public BooksModel(IBookRepositori bookRepositori)
        {
            _bookRepositori = bookRepositori;
        }

        public void OnGet()
        {
            Books = _bookRepositori.GetAllBooks();
        }


        public Book Book { get; private set; }
        public void OnGetDetails(int id)
        {
            Book = _bookRepositori.GetBookById(id);

        }
    }
}
