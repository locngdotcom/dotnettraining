using DotnetTraining.Models;
using DotnetTraining.Services.Student;
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
        private readonly IStudentLogicService _studentLogicService;

        public HomeController(
            ILogger<HomeController> logger,
            IStudentLogicService studentLogicService
            )
        {
            _studentLogicService = studentLogicService;
            _logger = logger;
        }

        

        [HttpGet("Student/api")]
        public IActionResult Studentapi()
        {
            var tudents = _studentLogicService.GetStudent();
            return Ok(tudents);
        }
    }
}
