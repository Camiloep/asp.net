using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuariosController : Controller
    {

        // Esto es para acceder a la base de datos
        private readonly ApplicationDbContext _context;

        // Constructor
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Metodo Get index
        public IActionResult Index()
        {
            // Creamos lista de datos IEnumerable
            IEnumerable<Usuarios> ListUsuarios = _context.Usuarios;
            return View(ListUsuarios); // Retorne la lista
        }
        // HTTP Get Create
        public IActionResult Create()
        {
            return View();
        }

        // POST create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuarios);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Get Editar

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var usuarios = _context.Usuarios.Find(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            return View(usuarios);
        }
        // POST Editar
        [HttpPost]
        [ValidateAntiForgeryToken] // Proteccion  del formulario. Evita los bots

        public IActionResult Editar(Usuarios Usuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Update(Usuarios);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Get Eliminar
        public IActionResult Eliminar(int? id)
        {
            var usuarios = _context.Usuarios.Find(id);
            if (usuarios == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuarios);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
