using DronePhotographerWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DronePhotographerWebSite.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project

        Context c = new Context();
        public ActionResult Project()
        {
            var degerler = c.Projects.ToList();
            return View(degerler);
        }
        public ActionResult ProjectDetail()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProjectAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProjectAdd(Project p)
        {
            return View();
        }

        public ActionResult ProjectGet(int id)
        {
            return View();
        }
        public ActionResult ProjectUpdate(int id)
        {
            return View();
        }
    }
}