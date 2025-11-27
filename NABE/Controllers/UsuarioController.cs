
using Microsoft.AspNetCore.Mvc;

namespace NABE.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsuarioController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}