using Microsoft.AspNetCore.Mvc;
using NABE.Models;
using NABE.Data;

namespace NABE.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly ProveedoresDAL _dal;

        public ProveedoresController(ProveedoresDAL dal)
        {
            _dal = dal;
        }

        // GET: /Proveedores
        public IActionResult Index()
        {
            var lista = _dal.Consultar();
            return View(lista);
        }

        // GET: /Proveedores/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Proveedores/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Proveedor model)
        {
            if (!ModelState.IsValid)
                return View(model);

            try
            {
                _dal.Crear(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}
