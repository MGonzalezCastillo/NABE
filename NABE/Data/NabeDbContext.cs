using Microsoft.EntityFrameworkCore;
using Nabe.Models;
using System.Collections.Generic;

namespace Nabe.Data
{
    public class NabeDbContext : DbContext
    {
        public NabeDbContext(DbContextOptions<NabeDbContext> options)
            : base(options)
        {
        }

        public DbSet<PerfilesModel> Perfiles { get; set; }
    }
}
