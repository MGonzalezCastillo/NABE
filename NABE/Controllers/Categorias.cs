using Microsoft.AspNetCore.Mvc;

namespace NABE.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(string categoriaSeleccionada, string estadoSeleccionado)
        {
            // Aquí es donde después podrás guardar en DB si lo deseas

            TempData["Mensaje"] = "Categoría guardada correctamente.";
            return RedirectToAction("Index");
        }
    }
}
