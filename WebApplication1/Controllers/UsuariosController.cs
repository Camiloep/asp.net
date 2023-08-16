using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
