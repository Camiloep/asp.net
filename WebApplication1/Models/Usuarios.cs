using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int NumeroTelefono { get; set; }

        public ICollection<Prestamos> Prestamos { get; set; }

    }
}
