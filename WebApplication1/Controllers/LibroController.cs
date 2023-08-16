using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LibroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
