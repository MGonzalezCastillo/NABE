using Microsoft.AspNetCore.Mvc;
using Nabe.Data;
using Nabe.Models;

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

