using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portafolio.Services
{
    public class Constantes
    {
        
        public static readonly SelectListItem[] CulturasUISoportadas = new SelectListItem[]{

            new SelectListItem{Value = "es", Text = "Español"},
            new SelectListItem{Value = "en", Text = "English"},
            new SelectListItem{Value = "fr", Text = "Français"},
        };
    }
}
