using ExamenP1CarvajalDavid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamenP1CarvajalDavid.Controllers
{
    public class HomeController : Controller

        //Commit de prueba
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
