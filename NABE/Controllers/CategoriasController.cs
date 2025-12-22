using Microsoft.AspNetCore.Mvc;
using NABE.Models;
using NABE.Data;

namespace NABE.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly CategoriasDAL _dal;

        public CategoriasController(CategoriasDAL dal)
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
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _dal.Crear(model);
            return RedirectToAction("Index");
        }
    }
}
