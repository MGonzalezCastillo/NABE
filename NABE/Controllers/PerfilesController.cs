using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
<<<<<<< HEAD
using Nabe.Data;
using Nabe.Models;
=======
=======
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
using NABE.Models;
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada

namespace Nabe.Controllers
{
    public class PerfilesController : Controller
    {
        private readonly PerfilesDAL _dal;

        public PerfilesController(PerfilesDAL dal)
        {
            _dal = dal;
        }

        public IActionResult Index()
        {
            var lista = _dal.Consultar();
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(PerfilesModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            ViewBag.Mensaje = _dal.Crear(model);
            return RedirectToAction("Index");
        }
    }
}

