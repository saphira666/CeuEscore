using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CeuEscore.Models;

namespace CeuEscore.Data
{
    public class CeuEscoreContext : DbContext
    {
        public CeuEscoreContext (DbContextOptions<CeuEscoreContext> options)
            : base(options)
        {
        }

        public DbSet<CeuEscore.Models.Department> Department { get; set; }

        //adicionado
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
