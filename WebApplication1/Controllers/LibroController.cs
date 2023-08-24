using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LibroController : Controller
    {
        // Esto es para acceder a la base de datos
        private readonly ApplicationDbContext _context;

        // Constructor
        public LibroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Metodo Get index
        public IActionResult IndexLibros()
        {
            // Creamos lista de datos IEnumerable
            IEnumerable<Libros> ListLibros = _context.Libros;
            return View(ListLibros); // Retorne la lista
        }
        // HTTP Get Create
        public IActionResult CreateLibro()
        {
            return View();
        }

        // POST create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateLibro(Libros libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();
                return RedirectToAction("IndexLibros");
            }
            return View();
        }

        // Get Editar

        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var libro = _context.Libros.Find(id);
            if(libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }
        // POST Editar
        [HttpPost]
        [ValidateAntiForgeryToken] // Proteccion  del formulario. Evita los bots

        public IActionResult Editar(Libros libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Update(libro);
                _context.SaveChanges();
                return RedirectToAction("IndexLibros");
            }
            return View();
        }

        // Get Eliminar
        public IActionResult Eliminar(int? id)
        {
            var libro = _context.Libros.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            _context.Libros.Remove(libro);
            _context.SaveChanges();
            return RedirectToAction("IndexLibros");
        }

    }
}

