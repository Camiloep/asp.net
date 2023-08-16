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
        public IActionResult Index()
        {
            // Creamos lista de datos IEnumerable
            IEnumerable<Libros> ListLibros = _context.Libros;
            return View(ListLibros); // Retorne la lista
        }
        // HTTP Get Create
        public IActionResult Create()
        {
            return View();
        }

        // POST create
        [HttpPost]

        public IActionResult Create(Libros libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

