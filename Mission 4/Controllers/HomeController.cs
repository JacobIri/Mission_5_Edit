using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFromContext _movieFromContext { get; set; }
        //_ makes file private

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieFromContext someStupidName)
        {
            _logger = logger;
            _movieFromContext = someStupidName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View("My Podcasts");
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
            //notice how i dont need to name the view name here because it is the same name as the iactionresult 
        }
        [HttpPost]
        public IActionResult Form(FormResponse fr)
        {
            _movieFromContext.Add(fr);
            _movieFromContext.SaveChanges();
            return View("Form Response Confirmation", fr);
            //Note the fr can be anything
        }
        public IActionResult JHFilmCollection()
        {
            return View("Index");
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
