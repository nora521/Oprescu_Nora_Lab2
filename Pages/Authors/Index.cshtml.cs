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
    public class IndexModel : PageModel
    {
        private readonly Oprescu_Nora_Lab2.Data.Oprescu_Nora_Lab2Context _context;

        public IndexModel(Oprescu_Nora_Lab2.Data.Oprescu_Nora_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
