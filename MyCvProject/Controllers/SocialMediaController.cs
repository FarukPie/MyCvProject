using Microsoft.Ajax.Utilities;
using MyCvProject.Models.Entity;
using MyCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCvProject.Controllers
{
    public class SocialMediaController : Controller
    {
        GenericRepositories<TblSocialMedia> repo = new GenericRepositories<TblSocialMedia>();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddSocialMedia");
            }

            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            TblSocialMedia t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetSocialMedia(int id)
        {
            TblSocialMedia t = repo.Find(x => x.ID == id);
            return View(t);

        }
        [HttpPost]
        public ActionResult GetSocialMedia(TblSocialMedia p)
        {
            if (!ModelState.IsValid)
            {
                return View("GetSocialMedia");
            }

            TblSocialMedia t = repo.Find(x => x.ID == p.ID);
            t.SocialMediaName = p.SocialMediaName;
            t.Link = p.Link;
            t.Icon = p.Icon;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}