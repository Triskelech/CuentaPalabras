using Microsoft.AspNetCore.Mvc;
using CuentaPalabras.Models;

namespace CuentaPalabras.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult MuestraConteo()
    {
        {
            string texto = Request.Form["texto"].ToString();
            Conteo conteo = new Conteo();
            Dictionary<String, int> diccionario = conteo.contar(texto);
            ViewData["conteo"] = diccionario;
            return View();
        }
    }
}
