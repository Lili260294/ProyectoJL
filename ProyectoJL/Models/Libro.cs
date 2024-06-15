using System.ComponentModel.DataAnnotations;

namespace ProyectoJL.Models
{
    public class Libro
    {
        [Key]
        public int IDLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string IDEditorial { get; set; }
        public string Año { get; set; }
        public string Precio { get; set; }
        public string Comentarios { get; set; }
        public string Foto { get; set; }

        public virtual ICollection<Editorial>  Editorials { get; set; } 
    }
}
