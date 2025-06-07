using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCvProject.Models.Entity;
using  MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class EducationController : Controller
    {
        GenericRepositories<TblEducation> repo = new GenericRepositories<TblEducation>();

        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(TblEducation p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            TblEducation t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetEducation(int id)
        {
            TblEducation t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult GetEducation(TblEducation p)
        {
            TblEducation t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.SubTitle = p.SubTitle;
            t.SubTitle2 = p.SubTitle2;
            t.GPA = p.GPA;
            t.Date = p.Date;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}