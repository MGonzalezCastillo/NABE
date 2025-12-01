using Microsoft.AspNetCore.Mvc;
using Nabe.Models;

namespace NABE.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Crear
        [HttpPost]
        public IActionResult Crear(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            // Aquí podrías guardar en BD (si luego la conectas)
            ViewBag.Mensaje = "Usuario creado correctamente (simulado).";

            return RedirectToAction("Index");
        }
    }
}
