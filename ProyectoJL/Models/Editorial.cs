using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System.ComponentModel.DataAnnotations;

namespace ProyectoJL.Models
{
    public class Editorial
    {
        [Key]
        public int IDEditorial { get; set; }
        public string NombreEditorial { get; set;}
        public string Nombrecontacto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set;}
        public string  Email { get; set; }
        public string Comentario { get; set; }


    }
}
