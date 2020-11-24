using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gorgan_Sorana_Lab8.Models;

namespace Gorgan_Sorana_Lab8.Data
{
    public class Gorgan_Sorana_Lab8Context : DbContext
    {
        public Gorgan_Sorana_Lab8Context (DbContextOptions<Gorgan_Sorana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Gorgan_Sorana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Gorgan_Sorana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Gorgan_Sorana_Lab8.Models.Category> Category { get; set; }
    }
}
