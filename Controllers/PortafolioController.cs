using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class PortafolioController : Controller
    {
        private readonly ILogger<PortafolioController> _logger;

        public PortafolioController(ILogger<PortafolioController> logger)
        {
            _logger = logger;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SobreMi()
        {
            return View();
        }

        public IActionResult Proyectos()
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
