using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Lab_4.ViewModels;
using Lab_4.Models;
using Microsoft.AspNet.Identity;

namespace Lab_4.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Courses

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new CourseViewModel();

            viewModel.Categories = _dbContext.categories.ToList();

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var course = new Course()
                {
                    LecturerId = User.Identity.GetUserId(),
                    DateTime = viewModel.GetDateTime(),
                    CategoryId = viewModel.Category,
                    Place = viewModel.Place
                };
                _dbContext.Courses.Add(course);
                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Authorize]
        public ActionResult Attending()
        {
            var userId = User.Identity.GetUserId();

            var courses = _dbContext.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Course)
                .Include("Lecture")
                .Include("Category")
                .ToList();

            var viewModel = new CourseViewModel
            {
                UpCommingCourses = courses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);
        }

        [Authorize]
        public ActionResult Mine()
        {
            return View();
        }
    }
}
