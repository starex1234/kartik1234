using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student_Portal.Models;
namespace Student_Portal.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index (EmployeeDetail emp)
        {
            return View();
        }

    }
}