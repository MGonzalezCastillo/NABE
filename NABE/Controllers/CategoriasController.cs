using Microsoft.AspNetCore.Mvc;
using Nabe.Models;

namespace NABE.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            // Redirige directo al formulario Crear
            return RedirectToAction("Crear");
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Categoria categoria)
        {
            // Aquí luego guardarás en la base de datos
            TempData["Mensaje"] = "Categoría guardada correctamente.";
            return RedirectToAction("Index");
        }
    }
}
