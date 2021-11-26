using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciomag_Andreea_Lab8.Models;

namespace Ciomag_Andreea_Lab8.Data
{
    public class Ciomag_Andreea_Lab8Context : DbContext
    {
        public Ciomag_Andreea_Lab8Context (DbContextOptions<Ciomag_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ciomag_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ciomag_Andreea_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
