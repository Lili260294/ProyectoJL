using Microsoft.EntityFrameworkCore;
using ProyectoJL.Models;

namespace ProyectoJL.Context
{
    public partial class ProyectJLContext : DbContext
    {
        public ProyectJLContext()
        {
        }

        public ProyectJLContext(DbContextOptions<ProyectJLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Editorial> Editorials { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }

    }
}
