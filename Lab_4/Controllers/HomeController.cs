using Lab_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public ActionResult Index()
        {
            var upCommingCourse = _dbContext.Courses
                .Include("Lecture")
                .Include("Category")
                .Where(c => c.DateTime > DateTime.Now);

            return View(upCommingCourse);
        }

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}