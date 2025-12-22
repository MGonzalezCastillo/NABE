using Microsoft.EntityFrameworkCore;
using Nabe.Models;
using NABE.Models;

namespace Nabe.Data
{
    public class NabeDbContext : DbContext
    {
        public NabeDbContext(DbContextOptions<NabeDbContext> options)
            : base(options)
        {
        }

        public DbSet<PerfilesModel> Perfiles { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }


    }
}
