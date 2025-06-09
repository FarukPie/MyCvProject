using MyCvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {GenericRepositories<TblAdmin> repo = new GenericRepositories<TblAdmin>();
       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
           
            var info=repo.List().FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);

            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.UserName,false);
                Session["UserName"]=info.UserName;
                return Redirect("/About/Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}