using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Lab_4.ViewModels;
using Lab_4.Models;

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

        [Authorize]
        [HttpPost]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel();
           
           viewModel.Categories = _dbContext.categories.ToList();

           return View(viewModel);
        }
    }
}