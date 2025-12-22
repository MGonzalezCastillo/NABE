using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using NABE.Models;
using NABE.Data;
=======
using Nabe.Models;
using NABE.Data;
using System.Security.Claims;
<<<<<<< HEAD
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
=======
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada

namespace NABE.Controllers
{
    public class CategoriasController : Controller
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private readonly CategoriasDAL _dal;

        public CategoriasController(CategoriasDAL dal)
        {
            _dal = dal;
        }

        public IActionResult Index()
        {
            var lista = _dal.Consultar();
            return View(lista);
=======
        private readonly ILogger<HomeController> _logger;

        public CategoriasController(ILogger<HomeController> logger)
        {
            _logger = logger;


>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
=======
        private readonly ILogger<HomeController> _logger;

        public CategoriasController(ILogger<HomeController> logger)
        {
            _logger = logger;


>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
        }

        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
<<<<<<< HEAD
<<<<<<< HEAD
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _dal.Crear(model);
            return RedirectToAction("Index");
=======
        public IActionResult Crear(CategoriaModel oCategoria)
        {
=======
        public IActionResult Crear(CategoriaModel oCategoria)
        {
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
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
<<<<<<< HEAD
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
=======
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
        }
    }
}
