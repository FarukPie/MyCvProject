using MyCvProject.Models.Entity;
using MyCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCvProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository repo =new ExperienceRepository();
        public ActionResult Index()
        {
            var experiencees = repo.List();
            return View(experiencees);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblExperience p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            TblExperience t=repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetExperience(int id)
        {
            TblExperience t = repo.Find(x => x.ID == id);
            return View(t);

        }

        [HttpPost]
        public ActionResult GetExperience(TblExperience p)
        {
            TblExperience t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.SubTitle = p.SubTitle;
            t.Description = p.Description;
            t.Date = p.Date;
            repo.TUpdate(t);
           return RedirectToAction("Index");

        }
    }
}