using Microsoft.AspNetCore.Mvc;
using Nabe.Models;
using NABE.Data;

namespace NABE.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuariosDAL _dal;

        public UsuarioController(UsuariosDAL dal)
        {
            _dal = dal;
        }

        // LISTAR
        public IActionResult Index()
        {
            var lista = _dal.Consultar();
            return View(lista);
        }

        // CREAR
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(UsuarioModel usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            _dal.Crear(usuario);
            return RedirectToAction("Index");
        }

        // EDITAR
        public IActionResult Editar(int id)
        {
            var usuario = _dal.Obtener(id);
            if (usuario == null) return NotFound();

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            _dal.Actualizar(usuario);
            return RedirectToAction("Index");
        }

        // ELIMINAR
        public IActionResult Eliminar(int id)
        {
            _dal.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
