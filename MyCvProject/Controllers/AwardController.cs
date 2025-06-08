using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCvProject.Models.Entity;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class AwardController : Controller
    {
 GenericRepositories<TblSertificate> repo= new GenericRepositories<TblSertificate>();
        public ActionResult Index()
        { 
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddSertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSertificate(TblSertificate p)
        {
            if(!ModelState.IsValid)
            {
                return View("AddSertificate");
            }
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSertificate(int id)
        {
            TblSertificate t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetSertificate(int id)
        {
            TblSertificate t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult GetSertificate(TblSertificate p)
        {
            TblSertificate t = repo.Find(x => x.ID == p.ID);
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");


        }
    }
}