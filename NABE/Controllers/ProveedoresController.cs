
using Microsoft.AspNetCore.Mvc;

namespace NABE.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly ILogger<ProveedoresController> _logger;

        public ProveedoresController(ILogger<ProveedoresController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}