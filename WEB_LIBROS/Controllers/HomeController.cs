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





            string resultado = apiBooks.getLibros("flores+inauthor:Mario", "AIzaSyAvKWpjkXwzkOCvPCqFMjQMRJkEhY3KKZI");

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