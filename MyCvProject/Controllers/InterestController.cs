using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCvProject.Models.Entity;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class InterestController : Controller
    {
        GenericRepositories<TblInterest> repo = new GenericRepositories<TblInterest>();
        public ActionResult Index()
        {
            var degerler=repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddInterest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInterest(TblInterest p)
        { if(!ModelState.IsValid)
            {
                return View("AddInterest");
            }
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
         
        public ActionResult DeleteInterest(int id)
        {
            TblInterest p = repo.Find(x => x.ID == id);
            repo.TDelete(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetInterest(int id)
        {
            TblInterest t=repo.Find(x=> x.ID==id);
            return View(t);
        }
        [HttpPost]
        public ActionResult GetInterest(TblInterest p)
        {
            TblInterest t=repo.Find(x=>x.ID == p.ID);
            t.Description1=p.Description1;
            t.Description2=p.Description2;
            t.ID = p.ID;
            repo.TUpdate(t);
            return RedirectToAction("Index");   
        }

    }
}