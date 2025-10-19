using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oprescu_Nora_Lab2.Data;
using Oprescu_Nora_Lab2.Models;

namespace Oprescu_Nora_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Oprescu_Nora_Lab2.Data.Oprescu_Nora_Lab2Context _context;

        public DetailsModel(Oprescu_Nora_Lab2.Data.Oprescu_Nora_Lab2Context context)
        {
            _context = context;
        }

        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
