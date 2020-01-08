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
            using (var c = new Context.M2LinkContext())
            {
                UserRepository r = new UserRepository(c);
                User me = r.GetUserByPseudo(HttpContext.User.Identity.Name);
                apm.Users = new Dictionary<User, Boolean>();
                foreach (User u in r.GetAll().ToList()) {
                    if (me.Following.Contains(u))
                    {
                        apm.Users.Add(u, true);
                    } else
                    {
                        apm.Users.Add(u, false);
                    }
                }
            }
            return View("All", apm);
        }

        [HttpGet, Route("AllProfiles/Profil/{pseudo}")]
        public ActionResult Profil(string pseudo)
        {
            AllProfilesModel apm = new AllProfilesModel();
            using (var c = new Context.M2LinkContext())
            {
                UserRepository r = new UserRepository(c);
                User usr = r.GetUserByPseudo(pseudo);
                if (usr == null)
                {
                    return RedirectToAction("Index");
                }


                Dictionary<User, Boolean> l = new Dictionary<User, Boolean>();
                l.Add(usr, false);// we don't care the boolean
                apm.Users = l;
            }
            return View("Profile", apm);
        }
    }
}