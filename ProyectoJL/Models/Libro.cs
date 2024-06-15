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
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public string Comentarios { get; set; }
        public byte [] Foto { get; set; }

        public virtual ICollection<Editorial>  Editorials { get; set; } 
    }
}
