using System.ComponentModel.DataAnnotations;

namespace ProyectoJL.Models
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }
        public int IDLibro { get; set; }
        public int IDSucursal { get; set; }
        public int Existencia { get; set; }
        public virtual ICollection<Libro> Libros { get; set; }
        public virtual ICollection<Sucursal> Sucursals { get; set; }

    }
}
