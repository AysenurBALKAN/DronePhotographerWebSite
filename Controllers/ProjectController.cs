using DronePhotographerWebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult ProjectList()
        {
            var degerler = c.Projects.ToList();
            return View(degerler);
        }

        [ValidateInput(false)]
        public ActionResult ProjectDetail(int id)
        {
            var urundeger = c.Projects.Find(id);
            return View("ProjectDetail", urundeger);
        }

        [HttpGet]
        public ActionResult ProjectAdd()
        {
            return View();
        }


        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ProjectAdd(Project p)
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {

                string dosyaadi = Path.GetFileName(Request.Files[i].FileName);
                string uzanti = Path.GetExtension(Request.Files[i].FileName);
                string yol = "~/img/" + dosyaadi + uzanti;
                Request.Files[i].SaveAs(Server.MapPath(yol));
                p.ProjectImage1 = "/img/" + dosyaadi + uzanti;

                if (i == 0)
                    p.ProjectImage1 = "/img/" + dosyaadi + uzanti;
                else if (i == 1)
                    p.ProjectImage2 = "/img/" + dosyaadi + uzanti;
                else if (i == 2)
                    p.ProjectImage3 = "/img/" + dosyaadi + uzanti;

            }
            c.Projects.Add(p);
            c.SaveChanges();
            return RedirectToAction("ProjectList");
       
        }

        public ActionResult ProjectGet(int id)
        {
   
            var urundeger = c.Projects.Find(id);
            return View("ProjectGet", urundeger);
        }

        [ValidateInput(false)]
       
        public ActionResult ProjectUpdate(Project p)
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {

                string dosyaadi = Path.GetFileName(Request.Files[i].FileName);
                string uzanti = Path.GetExtension(Request.Files[i].FileName);
                string yol = "~/img/" + dosyaadi + uzanti;
                Request.Files[i].SaveAs(Server.MapPath(yol));
                p.ProjectImage1 = "/img/" + dosyaadi + uzanti;

                if (i == 0)
                    p.ProjectImage1 = "/img/" + dosyaadi + uzanti;
                else if (i == 1)
                    p.ProjectImage2 = "/img/" + dosyaadi + uzanti;
                else if (i == 2)
                    p.ProjectImage3 = "/img/" + dosyaadi + uzanti;

            }

            var urn = c.Projects.Find(p.ProjectId);
            urn.ProjetTitle = p.ProjetTitle;
            urn.ProjectDescription = p.ProjectDescription;
            urn.ProjectDetail = p.ProjectDetail;
            urn.ProjectImage1 = p.ProjectImage1;
            urn.ProjectImage2 = p.ProjectImage2;
            urn.ProjectImage3 = p.ProjectImage3;
           
            c.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        public ActionResult ProjectDelete(int id)
        {
            var urn = c.Projects.Find(id);
            c.Projects.Remove(urn);
            c.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}