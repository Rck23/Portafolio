using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositorioProyectos
    {
        List<Proyectos> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyectos> ObtenerProyectos()
        {
            return new List<Proyectos>
            {
                new Proyectos
                {
                    Titulo = "Mi portafolio",
                    Descripcion = "Visita el código de este portafolio.",
                    Fecha = "Diciembre 2022",
                    Tecnologias ="C#        .Net 6"
                },
                new Proyectos
                {
                    Titulo = "Manejo de presupuesto",
                    Descripcion = "Esta aplicación te permite manejar tus finanzas por día, mes, año y te muestra los diferentes gastos e ingresos, ademas cuentas con categorias, transacciones, reportes, cuentas y tipos de cuentas.",
                    Fecha = "Enero 2023",
                    Tecnologias ="C#        .Net 6"

                }
            };
        }
    }
}
