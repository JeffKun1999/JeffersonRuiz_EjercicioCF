using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JeffersonRuiz_EjercicioCF.Models;

namespace JeffersonRuiz_EjercicioCF.Data
{
    public class JeffersonRuiz_EjercicioCF_DBContext : DbContext
    {
        public JeffersonRuiz_EjercicioCF_DBContext (DbContextOptions<JeffersonRuiz_EjercicioCF_DBContext> options)
            : base(options)
        {
        }

        public DbSet<JeffersonRuiz_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
        public DbSet<JeffersonRuiz_EjercicioCF.Models.Promo> Promo { get; set; } = default!;
        
    }
}
