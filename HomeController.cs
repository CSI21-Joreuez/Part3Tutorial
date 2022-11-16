using AspNetCore;
using Microsoft.AspNetCore.Mvc;
namespace VideoTutorial
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult listaEjemplos()
        {

            List<string> listaEjemplos = new List<string>();
            listaEjemplos.Add("Ejemplo BBDD First");
            listaEjemplos.Add("Ejemplo Code First");
            listaEjemplos.Add("Ejemplo 1");
            listaEjemplos.Add("Ejemplo 2");
            listaEjemplos.Add("Ejemplo MVC Vistas Razor");
            ViewData["ListaEjemplos"] = listaEjemplos;
            
            return View(listaEjemplos);
        }
        [HttpPost]
        public IActionResult listaEjemplos(string selEjemplos)
        {
           
            ViewBag.Nombre = selEjemplos;
            List<String> listaEjemplos = (List<String>)ViewData["ListaEjemplos"];
          return View(listaEjemplos);
        }

    }
}
