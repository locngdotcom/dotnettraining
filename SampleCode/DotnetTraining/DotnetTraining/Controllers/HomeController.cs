using DotnetTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetTraining.Controllers
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
            var student1 = new Student { Class = "Rookies", Name = "Nguyen Van A" };
            var student2 = new Student { Class = "Rookies", Name = "Nguyen Van B" };
            var student3 = new Student { Class = "Rookies", Name = "Nguyen Van C" };
            var listOfStudents = new List<Student>();
            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);

            var tag = new SWTag { TagName = "tag1", Description = "tag1" };
            ViewBag.tag = tag;

            return View(listOfStudents);
        }

        public IActionResult Privacy()
        {
            ViewData["Layout"] = "_LayoutRookie";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
