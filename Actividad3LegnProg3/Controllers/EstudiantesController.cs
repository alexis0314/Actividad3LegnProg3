using Actividad3LegnProg3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace Actividad3LegnProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registro()
        {
            ViewBag.Carrera=new List<Stream> {};
            return View();
        }
        [HttpGet]
        public IActionResult Redistro(EstudianteViewModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Messege="El Estudiante se ha registrado";
                return View(model);
            }
            return View(model);

        }


    }
}
