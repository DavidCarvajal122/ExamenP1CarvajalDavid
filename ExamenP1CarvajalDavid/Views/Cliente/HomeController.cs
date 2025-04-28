using Microsoft.AspNetCore.Mvc;

namespace ExamenP1CarvajalDavid.Views.Cliente
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
