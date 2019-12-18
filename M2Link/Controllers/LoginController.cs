using M2Link.Entities;
using M2Link.Models;
using M2Link.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace M2Link.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Index(LoginModel rm)
        {


            if (rm != null)
            {
                Context.M2LinkContext c = new Context.M2LinkContext();
                UserRepository r = new UserRepository(c);
                //TODO test si l'user n'appartient pas au registre des users
                User u = r.GetUserByPseudo(rm.Pseudo);
                if (u == null)
                {
                    ModelState.AddModelError("Login", "Le pseudo entré n'est pas enregistré dans la base de données.");
                    return View("Login");
                }

                if (! u.Mdp.Equals(rm.Mdp))
                {
                    ModelState.AddModelError("Mdp", "Votre mot de passe est incorrect.");
                    return View("Login");
                }
            }

            if (ModelState.IsValid)
            {
                //Ici, l'user est dans la DB

                FormsAuthentication.SetAuthCookie(rm.Pseudo, false);
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }
    }
}