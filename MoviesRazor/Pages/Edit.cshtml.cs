using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesRazor.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRazor.Pages
{
    public class EditModel : PageModel
    {
        private readonly MoviesContext _context;

        public EditModel(MoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movies Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            Movie = movie;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var movieToUpdate = await _context.Movies.FirstOrDefaultAsync(m => m.Id == Movie.Id);

            if (movieToUpdate == null)
            {
                return NotFound();
            }

            movieToUpdate.Title = Movie.Title;
            movieToUpdate.Year = Movie.Year;
            movieToUpdate.Director = Movie.Director;
            movieToUpdate.Genre = Movie.Genre;
            movieToUpdate.Info = Movie.Info;

            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files[0];
                using (var memoryStream = new System.IO.MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    // Here you need to save the file to the server and set the Img property accordingly
                    // movieToUpdate.Img = "path/to/saved/file";
                }
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
