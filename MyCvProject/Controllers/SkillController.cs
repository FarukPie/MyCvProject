using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCvProject.Repositories;
using MyCvProject.Models.Entity;

namespace MyCvProject.Controllers
{
    public class SkillController : Controller
    {
      GenericRepositories<TblSkill> repo=new GenericRepositories<TblSkill>();   
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            if(!ModelState.IsValid)
            {
                return View("Index");
            }
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            TblSkill t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetSkill(int id)
        {
            TblSkill t = repo.Find(x => x.ID == id);
            return View(t);

        }

        [HttpPost]
        public ActionResult GetSkill(TblSkill p)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            TblSkill t = repo.Find(x => x.ID == p.ID);
            t.Skill = p.Skill;
            t.SkillValue = p.SkillValue;
            repo.TUpdate(t);
            return RedirectToAction("Index");

        }

    }
}