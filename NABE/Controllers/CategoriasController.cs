using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using NABE.Models;
using NABE.Data;
=======
using Nabe.Models;
using NABE.Data;
using System.Security.Claims;

namespace NABE.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CategoriasController(ILogger<HomeController> logger)
        {
            _logger = logger;


        }

        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Crear(CategoriaModel oCategoria)
        {
            //oCategoria.idUsuarioRegistro = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                CategoriasDAL.CreateCategoria(oCategoria);
                return RedirectToAction("Crear");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}
