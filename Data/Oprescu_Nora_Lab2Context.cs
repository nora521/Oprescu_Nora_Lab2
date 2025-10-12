using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oprescu_Nora_Lab2.Models;

namespace Oprescu_Nora_Lab2.Data
{
    public class Oprescu_Nora_Lab2Context : DbContext
    {
        public Oprescu_Nora_Lab2Context (DbContextOptions<Oprescu_Nora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Oprescu_Nora_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Oprescu_Nora_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
