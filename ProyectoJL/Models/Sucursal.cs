using System.ComponentModel.DataAnnotations;

namespace ProyectoJL.Models
{
    public class Sucursal
    {
        [Key]
        public int IDSucursal { get; set; }
        public string Nombresucursal { get; set; }
        public string Nombreencargado { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string comentario { get; set; }

    }
}
