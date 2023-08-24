using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class Prestamos
    {
        public int Id { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int LibrosId { get; set; }
        public Libros Libros { get; set; }

        public int UsuariosId { get; set; }
        public Usuarios Usuarios { get; set; }


    }
}
