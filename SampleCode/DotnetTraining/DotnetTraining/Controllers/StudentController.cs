using DotnetTraining.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DotnetTraining.Controllers
{
    public class StudentController : Controller
    {
        private static readonly string _fileName = "student.txt";

        [HttpGet("Students")]
        public IActionResult Student()
        {
            var students = GetStudentData();
            return View(students);
        }

        [HttpGet("Student/{id}")]
        public IActionResult DetailedStudent(string id)
        {
            var students = GetStudentData();
            var student = students.Where(n => n.Id == id).FirstOrDefault();

            return View(student);
        }

        [HttpPost("Student/{id}")]
        public IActionResult DetailedStudent([FromForm] Student request)
        {
            var listOfStudents = GetStudentData();
            listOfStudents.RemoveAll(n => n.Id == request.Id);
            listOfStudents.Add(request);

            System.IO.File.WriteAllText(_fileName, JsonSerializer.Serialize(listOfStudents));

            return RedirectToAction("Student");
        }

        [HttpGet("Student/Create")]
        public IActionResult CreateStudent()
        {
            return View(new Student { });
        }

        [HttpPost("Student/Create")]
        public IActionResult CreateStudent([FromForm] Student request)
        {
            var listOfStudents = GetStudentData();
            request.Id = Guid.NewGuid().ToString();
            listOfStudents.Add(request);

            System.IO.File.WriteAllText(_fileName, JsonSerializer.Serialize(listOfStudents));

            return RedirectToAction("Student");
        }

        [HttpGet("Student/{id}/delete")]
        public IActionResult TagDelete(string id)
        {
            var listOfStudents = GetStudentData();
            listOfStudents.RemoveAll(n => n.Id == id);

            System.IO.File.WriteAllText(_fileName, JsonSerializer.Serialize(listOfStudents));
            return RedirectToAction("Students");
        }

        private List<Student> GetStudentData()
        {
            try
            {
                var studentText = System.IO.File.ReadAllText(_fileName);
                var listOfStudents = JsonSerializer.Deserialize<List<Student>>(studentText);
                return listOfStudents;
            }
            catch (Exception)
            {

                var student1 = new Student { Id = Guid.NewGuid().ToString(), Class = "Rookies", Name = "Nguyen Van A" };
                var student2 = new Student { Id = Guid.NewGuid().ToString(), Class = "Rookies", Name = "Nguyen Van B" };
                var student3 = new Student { Id = Guid.NewGuid().ToString(), Class = "Rookies", Name = "Nguyen Van C" };
                var listOfStudents = new List<Student>();
                listOfStudents.Add(student1);
                listOfStudents.Add(student2);
                listOfStudents.Add(student3);

                System.IO.File.WriteAllText(_fileName, JsonSerializer.Serialize(listOfStudents));

                return listOfStudents;
            }
        }
    }
}