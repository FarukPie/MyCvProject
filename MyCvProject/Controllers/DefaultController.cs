using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCvProject.Models.Entity;

namespace MyCvProject.Controllers
{
    public class DefaultController : Controller
    {
        MyCvDbEntities db = new MyCvDbEntities();   

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Header()
        {
           
            return PartialView();
        }   

        public PartialViewResult Navbar()
        {
            var degerler = db.TblAbout.ToList();

            return PartialView(degerler);
        }

        public PartialViewResult About()
        {
            var degerler = db.TblAbout.ToList();    
            return PartialView(degerler);
        }
        public PartialViewResult Experience()
        {
            var degerler = db.TblExperience.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Education()
        {
            var degerler=db.TblEducation.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Skill()
        {
            var degerler = db.TblSkill.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Interest()
        {
            var degerler = db.TblInterest.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Award()
        {
            var degerler = db.TblSertificate.ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(TblContact t)
        {
            db.TblContact.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}