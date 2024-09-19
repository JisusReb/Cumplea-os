using CUMPLEAÑOS_ALEJANDRA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CUMPLEAÑOS_ALEJANDRA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Cumpleaños(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "Alejandra";
            }

            return View(model: nombre);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
