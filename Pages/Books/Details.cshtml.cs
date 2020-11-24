using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gorgan_Sorana_Lab8.Data;
using Gorgan_Sorana_Lab8.Models;

namespace Gorgan_Sorana_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Gorgan_Sorana_Lab8.Data.Gorgan_Sorana_Lab8Context _context;

        public DetailsModel(Gorgan_Sorana_Lab8.Data.Gorgan_Sorana_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
