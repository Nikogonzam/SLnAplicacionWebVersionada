using System.Diagnostics;
using AplicacionWebVersionada.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWebVersionada.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger">este parametro...</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Accion que se encarga de...
        /// </summary>
        /// <returns>view...</returns>
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
