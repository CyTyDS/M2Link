using M2Link.Entities;
using M2Link.Models;
using M2Link.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M2Link.Controllers
{
    [Authorize]
    public class AllProfilesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            AllProfilesModel apm = new AllProfilesModel();
            Context.M2LinkContext c = new Context.M2LinkContext();
            UserRepository r = new UserRepository(c);
            apm.Users = r.GetAll().ToList();
            return View("All", apm);
        }

        [HttpGet, Route("AllProfiles/Profil/{pseudo}")]
        public ActionResult Profil(string pseudo)
        {
            AllProfilesModel apm = new AllProfilesModel();
            Context.M2LinkContext c = new Context.M2LinkContext();
            UserRepository r = new UserRepository(c);
            User usr = r.GetUserByPseudo(pseudo);
            if (usr == null)
            {
                return RedirectToAction("Index");
            }
            List<User> l = new List<User>();
            l.Add(usr);
            apm.Users = l;
            return View("Profile", apm);
        }
    }
}