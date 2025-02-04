using System.Diagnostics;
using FirstASP.NETWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstASP.NETWebApp.Controllers
{
    public class HomeController : Controller
    // It needs to be named HomeController since it's controlling the Views in the Home folder
    // It also has to match the file (class) name in the Controllers folder
    // The HomeController class inherits from the Controller class (shown by the colon + controller)

    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Hobby()
        {
            return View();
        }

        public IActionResult Calculator()
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
