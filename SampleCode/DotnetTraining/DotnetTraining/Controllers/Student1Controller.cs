using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetTraining.Controllers
{
    public class Student1Controller : Controller
    {
        // GET: Student1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Student1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
