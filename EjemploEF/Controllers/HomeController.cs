using EjemploEF.Models;
using EjemploEF.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploEF.Controllers
{
    public class HomeController : Controller
    {
        private IEnrrollments _enrrollments;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IEnrrollments enrrollments)
        {
            _enrrollments = enrrollments;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var getInnerJoin = _enrrollments.GetInnerJoin().ToList();

            _ = getInnerJoin;

            return View(getInnerJoin);
            
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