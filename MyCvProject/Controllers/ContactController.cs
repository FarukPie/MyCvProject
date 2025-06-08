using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCvProject.Models.Entity;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class ContactController : Controller
    {
       GenericRepositories<TblContact> repo=new GenericRepositories<TblContact>();
        public ActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var degerler = repo.List(); 
            return View(degerler);
        }

        public ActionResult DeleteContact(int id)
        {
            TblContact t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(TblContact p)
        {
            TblContact t = new TblContact();
            t.NameSurname = Request.Form["NameSurname"];
            t.Mail = Request.Form["Mail"];
            t.Subject = Request.Form["Subject"];
            t.Message = Request.Form["Message"];
            t.Date = DateTime.Now;
            repo.Tadd(t);
            return RedirectToAction("Index");
        }



    }
}