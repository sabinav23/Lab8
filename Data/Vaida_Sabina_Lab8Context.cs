using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vaida_Sabina_Lab8.Models;

namespace Vaida_Sabina_Lab8.Data
{
    public class Vaida_Sabina_Lab8Context : DbContext
    {
        public Vaida_Sabina_Lab8Context (DbContextOptions<Vaida_Sabina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Vaida_Sabina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Vaida_Sabina_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
