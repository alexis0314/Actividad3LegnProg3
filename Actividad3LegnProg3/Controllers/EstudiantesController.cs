using Actividad3LegnProg3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Actividad3LegnProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> Estudiante = new List<EstudianteViewModel>()
        {
             new EstudianteViewModel()
        };

        public EstudiantesController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Lista()
        {
            var estudiantes = Registro();

            return View();
        }


        [HttpGet]
        public IActionResult Registro()
        {
            ViewBag.Carrera=new List<Stream> {};
            return View();
        }
        [HttpPost]
        public IActionResult Registro(EstudianteViewModel model)
        {
            if(ModelState.IsValid)
            {
                Estudiante.Add(model);
                ViewBag.Messege="El Estudiante se ha registrado";
                return View(model);
            }
            return View(model);

        }


    }
}
