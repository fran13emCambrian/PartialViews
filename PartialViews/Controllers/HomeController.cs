using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViews.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews.Controllers
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

        public IActionResult About()
        {
            Movie mv = new Movie();
            mv.Title = "Die Hard";
            mv.Duration = "120 min";
            mv.Description = "Movie about a police";

            mv.Title2 = "Fast & Furious";
            mv.Duration2 = "110 min";
            mv.Description2 = "Movie about fast cars";

            mv.Title3 = "Baby Driver";
            mv.Duration3 = "90 min";
            mv.Description3 = "Movie about a good driver";

            return View(mv);
           

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
