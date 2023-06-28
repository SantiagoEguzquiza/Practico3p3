using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB_LIBROS.Models;
using API_LIBROS;
using Newtonsoft.Json;

namespace WEB_LIBROS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            API apiBooks = new API();


            string resultado = apiBooks.getLibros("dormir+inauthor:Mario+intitle:cama", "AIzaSyAvKWpjkXwzkOCvPCqFMjQMRJkEhY3KKZI");

            var listaLibros = JsonConvert.DeserializeObject<LIBROS>(resultado);
            ViewBag.Libros = listaLibros.Items;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string autor, string titulo, string descripcion)
        {
            if (autor != null)
            {
                autor = autor.ToLower();
                autor = "+inauthor:" + autor;
            }else if (autor == null) { autor = ""; }

            if (titulo != null)
            {
                titulo = titulo.ToLower();
                titulo = "+intitle:" + titulo;
            }else if (titulo == null) { titulo = ""; }

            if (descripcion != null)
            {
                descripcion = descripcion.ToLower();
            }
            else if (descripcion == null) { descripcion = ""; }

            string q = descripcion + autor + titulo;

            API apiBooks = new API();


            string resultado = apiBooks.getLibros(q , "AIzaSyAvKWpjkXwzkOCvPCqFMjQMRJkEhY3KKZI");

            var listaLibros = JsonConvert.DeserializeObject<LIBROS>(resultado);
            ViewBag.Libros = listaLibros.Items;
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