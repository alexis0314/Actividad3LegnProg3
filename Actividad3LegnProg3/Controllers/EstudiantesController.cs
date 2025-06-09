using Microsoft.AspNetCore.Mvc;

namespace Actividad3LegnProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
    }
}
