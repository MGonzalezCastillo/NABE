
using Microsoft.AspNetCore.Mvc;

namespace NABE.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProveedoresController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}