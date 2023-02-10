using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class PortafolioController : Controller
    {
        private readonly ILogger<PortafolioController> _logger;
        private readonly IRepositorioProyectos _repositorioProyectos;

        public PortafolioController(ILogger<PortafolioController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
           _repositorioProyectos = repositorioProyectos;
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
            var proyectos = _repositorioProyectos.ObtenerProyectos().ToList();

            return View(proyectos);
        }

        //ACCIÓN CAMBIAR IDIOMA & CREACION DE COOKIE DE IDIOMA
        public IActionResult CambiarIdioma(string cultura, string urlRetorno)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cultura)),

                    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(urlRetorno);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
