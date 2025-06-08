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
            var degerler = repo.List(); 
            return View(degerler);
        }

        public ActionResult DeleteContact(int id)
        {
            TblContact t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");

        }

     

    }
}