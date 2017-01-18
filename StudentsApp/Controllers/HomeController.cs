using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsApp.Models;

namespace StudentsApp.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();

        // GET: /Home/Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Home/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(model);
                db.SaveChanges();
                return RedirectToAction("Results");
            }
            return View(model);
        }

        // GET: /Home/Results
        [HttpGet]
        public ActionResult Results()
        {
            return View(db.Students);
        }
    }
}