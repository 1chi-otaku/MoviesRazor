using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesRazor.Models;

namespace MoviesRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MoviesContext _context;

        public IndexModel(MoviesContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get; set; } = default!;
        public async Task OnGet()
        {
            if (_context.Movies != null)
            {
                Movies = await _context.Movies.ToListAsync();
            }
        }
    }
}
