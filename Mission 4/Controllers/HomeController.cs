using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //dynamically created variables that can be seen in all controllers? Fact check plz
            ViewBag.CategoryEntry = _movieFromContext.CategoryEntry.ToList();
                                    //var category = _movieFromContext.CategoryEntry.ToList();

            return View();
         
            //notice how i dont need to name the view name here because it is the same name as the iactionresult 
        }
        [HttpPost]
        public IActionResult Form(FormResponse fr) //Note the fr can be anything
        {
            if(ModelState.IsValid)
            {
                _movieFromContext.Add(fr);
                _movieFromContext.SaveChanges();
                return View("Form Response Confirmation", fr);
            }
            else
            {
                ViewBag.CategoryEntry = _movieFromContext.CategoryEntry.ToList();
                return View(fr);
            }

            
            
        }
        public IActionResult JHFilmCollection()
        {
            return View("Index");
        }

        public IActionResult Table()
        {
            //Note: Where I'm taking this out'
            var applicationsTableFiller = _movieFromContext.Responses
                .Include(x=> x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applicationsTableFiller);

        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            ViewBag.CategoryEntry = _movieFromContext.CategoryEntry.ToList();

            var formApplication = _movieFromContext.Responses.Single(x=>x.FormId == id);

            return View("Form", formApplication);
        }

        [HttpPost]
        public IActionResult Edit(FormResponse frrr)
        {
            _movieFromContext.Update(frrr);
            _movieFromContext.SaveChanges();
            return RedirectToAction("Table");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var application= _movieFromContext.Responses.Single(x => x.FormId == id);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            _movieFromContext.Responses.Remove(fr);
            _movieFromContext.SaveChanges();
            return RedirectToAction("Table");
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
