using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Portafolio;
using Portafolio.Services;
using System.Globalization;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization(opciones =>
    {   //TRADUCIR LAS ANOTACIONES DE DATOS
        opciones.DataAnnotationLocalizerProvider = (_, factoria) =>
            factoria.Create(typeof(RecursoCompartido));
    });



//LOCALIZACIÓN EN EL PROYECTO (para utilizar varios idiomas)
builder.Services.AddLocalization(opciones =>
{
    //Agregacion de los recursos (en este caso idioma diferente)
    opciones.ResourcesPath = "Resources";
});

var app = builder.Build();

//AGREGAR DISTINTOS IDIOMAS AL PROYECTO
//LOCALIZAR LAS PETICIONES DEL USUARIO
app.UseRequestLocalization(opciones =>
{
    // PONER IDIOMA POR DEFAULT (indicar)
    opciones.DefaultRequestCulture = new RequestCulture("es");

    opciones.SupportedUICultures = Constantes.CulturasUISoportadas
        .Select(cultura => new CultureInfo(cultura.Value)).ToList();
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Portafolio}/{action=Index}/{id?}");

app.Run();
