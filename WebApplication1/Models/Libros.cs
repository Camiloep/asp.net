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
        public string Autor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [DataType(DataType.Date)]
        public DateTime AnoPublicacion { get; set; }

        public ICollection<Prestamos> Prestamos { get; set; }

    }
}
