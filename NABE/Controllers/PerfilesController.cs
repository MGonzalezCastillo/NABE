// Librerías necesarias para usar MVC, Entity Framework y modelos del proyecto
using Microsoft.AspNetCore.Mvc; // Permite crear controladores y devolver vistas
using Microsoft.EntityFrameworkCore; // Permite trabajar con la base de datos mediante EF Core
using Nabe.Data; // Acceso al DbContext donde está la conexión con la BD
using Nabe.Models; // Acceso al modelo PerfilesModel

namespace Nabe.Controllers
{
    // Controlador para manejar todo el CRUD de la tabla Perfiles
    public class PerfilesController : Controller
    {
        // Variable para acceder a la BD con Entity Framework
        private readonly NabeDbContext _context;

        // Constructor que recibe la conexión a la BD por inyección de dependencias
        public PerfilesController(NabeDbContext context)
        {
            _context = context;
        }

        // GET: Index = Mostrar todos los registros
        public IActionResult Index()
        {
            var lista = _context.Perfiles.ToList(); // Obtener todos los perfiles de la BD
            return View(lista); // Enviar la lista a la vista
        }

        // GET: Crear = Mostrar formulario para crear nuevo perfil
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Crear = Guardar nuevo perfil en la BD
        [HttpPost]
        public IActionResult Crear(PerfilesModel modelo)
        {
            if (!ModelState.IsValid) // Validar datos del formulario
                return View(modelo);

            _context.Perfiles.Add(modelo); // Agregar nuevo registro
            _context.SaveChanges(); // Guardar en la base de datos

            return RedirectToAction("Index"); // Redirigir al listado
        }

        // GET: Editar = Mostrar datos que se podrán modificar
        public IActionResult Editar(int id)
        {
            var perfil = _context.Perfiles.Find(id); // Buscar por ID
            if (perfil == null)
                return NotFound(); // Si no existe, error 404

            return View(perfil); // Enviar datos a la vista
        }

        // POST: Editar = Guardar cambios en la BD
        [HttpPost]
        public IActionResult Editar(PerfilesModel modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            _context.Perfiles.Update(modelo); // Actualizar el registro
            _context.SaveChanges(); // Guardar cambios

            return RedirectToAction("Index");
        }

        // GET: Eliminar = Confirmar si se desea eliminar
        public IActionResult Eliminar(int id)
        {
            var perfil = _context.Perfiles.Find(id);
            if (perfil == null)
                return NotFound();

            return View(perfil); // Mostrar confirmación
        }

        // POST: Eliminar = Borrar de verdad el registro
        [HttpPost, ActionName("Eliminar")]
        public IActionResult EliminarConfirmado(int id)
        {
            var perfil = _context.Perfiles.Find(id);
            if (perfil == null)
                return NotFound();

            _context.Perfiles.Remove(perfil); // Eliminar
            _context.SaveChanges(); // Guardar cambios

            return RedirectToAction("Index"); // Regresar al listado
        }

        // GET: Detalles = Mostrar información de un perfil
        public IActionResult Detalles(int id)
        {
            var perfil = _context.Perfiles.Find(id);
            if (perfil == null)
                return NotFound();

            return View(perfil);
        }
    }
}

