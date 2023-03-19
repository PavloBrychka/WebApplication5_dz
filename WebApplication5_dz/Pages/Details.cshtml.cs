using LibraryApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication5_dz.Pages.Books
{
    public class DetailsModel : PageModel
    {

        int Id;
        public Book book;

        private readonly IBookRepositori _bookRepositori;
        public DetailsModel(IBookRepositori bookRepositori)
        {
            _bookRepositori = bookRepositori;
        }
        public void OnGet(int id)
        {
            Id = id;
            book = _bookRepositori.GetBookById(id);

        }
    }
}
