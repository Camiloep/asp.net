using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Libros
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string libros { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public double precio { get; set; }

    }
}
