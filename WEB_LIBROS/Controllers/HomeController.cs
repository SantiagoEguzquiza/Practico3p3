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
            return View();
        }
        [HttpPost]
        public IActionResult Index(string autor, string titulo, string descripcion, string pagina)
        {
            string auxAutor = "";
            string auxTitulo = "";
            string auxDescripcion = "";

            if (autor != null)
            {
                auxAutor = autor.ToLower();
                auxAutor = "+inauthor:" + auxAutor;
            }
            else if (autor == null) { auxAutor = ""; }

            if (titulo != null)
            {
                auxTitulo = titulo.ToLower();
                auxTitulo = "+intitle:" + auxTitulo;
            }
            else if (titulo == null) { auxTitulo = ""; }

            if (descripcion != null)
            {
                auxDescripcion = descripcion.ToLower();
            }
            else if (descripcion == null) { auxDescripcion = ""; }

            string q = auxDescripcion + auxAutor + auxTitulo;

            API apiBooks = new API();


            string resultado = apiBooks.getLibros(q, "AIzaSyAvKWpjkXwzkOCvPCqFMjQMRJkEhY3KKZI", pagina);

            var listaLibros = JsonConvert.DeserializeObject<LIBROS>(resultado);

            if (listaLibros is not null)
            {
                ViewBag.Libros = listaLibros.Items;
            }

            ViewBag.Autor = autor;
            ViewBag.Titulo = titulo;
            ViewBag.Desc = descripcion;

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