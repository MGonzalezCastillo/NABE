using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using NABE.Models;

namespace NABE.Controllers
{
    public class PerfilesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PerfilesController(ILogger<HomeController> logger)
        {
            _logger = logger;


        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
