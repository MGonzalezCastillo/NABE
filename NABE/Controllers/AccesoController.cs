using Microsoft.AspNetCore.Mvc;

namespace NABE.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
