using MyCvProject.Models.Entity;
using MyCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCvProject.Controllers
{
    public class AboutController : Controller
    {
        AboutRepository repo = new AboutRepository();
        public ActionResult Index()
        {
            var abouts = repo.List();
            return View(abouts);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(TblAbout p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            TblAbout t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetAbout(int id)
        {
            TblAbout t = repo.Find(x => x.ID == id);
            return View(t);

        }

        [HttpPost]
        public ActionResult GetAbout(TblAbout p)
        {
            TblAbout t = repo.Find(x => x.ID == p.ID);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Adress = p.Adress;
            t.Phone = p.Phone;
            t.Mail = p.Mail;
            t.Description = p.Description;
            t.ImgUrl = p.ImgUrl;
            repo.TUpdate(t);
            return RedirectToAction("Index");

        }
    }
}