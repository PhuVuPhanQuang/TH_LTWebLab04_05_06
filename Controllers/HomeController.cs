using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH_LTWebLab04_05_06.Models;
using System.Data.Entity;


namespace TH_LTWebLab04_05_06.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var uncomingCourses = _dbContext.Courses
                .Include(a => a.Lecturer)
                .Include(d => d.Category)
                .Where(c => c.DateTime > DateTime.Now);
            return View(uncomingCourses);
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