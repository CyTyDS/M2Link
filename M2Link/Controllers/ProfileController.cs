using M2Link.Entities;
using M2Link.Models;
using M2Link.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace M2Link.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        [HttpGet]
        public ActionResult Edit()
        {
            ProfileModel rm = null;
            using (var c = new Context.M2LinkContext())
            {
                UserRepository r = new UserRepository(c);
                User usr = r.GetUserByPseudo(HttpContext.User.Identity.Name);
                
                if (usr == null)
                {
                    rm = new ProfileModel();
                }
                else
                {
                    rm = new ProfileModel
                    {
                        Nom = usr.Nom,
                        Prenom = usr.Prenom,
                        Email = usr.Email,
                        Pseudo = usr.Pseudo,
                        Mdp = usr.Mdp,
                        Messages = usr.Messages
                    };
                }
            }
            return View("Edit", rm);
        }

        [HttpPost]
        public ActionResult Edit(ProfileModel rm)
        {
            if (rm != null)
            {
                if (rm.Mdp != null)
                {
                    if (rm.Mdp.Length < 8)
                    {
                        ModelState.AddModelError("Mdp", "Le Mot de passe entré fait moins de 8 caractères.");
                        return View("Form");
                    }

                    Regex r = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                    if (!r.IsMatch(rm.Mdp))
                    {
                        ModelState.AddModelError("Mdp", "Le Mot de passe entré n'est pas assez sécurisé.\n" +
                            " Pensez à utiliser au moins une majuscule, une minuscule, un chiffre et un caratères spécial.");
                        return View("Form");
                    }
                }
            }

            if (ModelState.IsValid)
            {
                using (var c = new Context.M2LinkContext())
                {
                    UserRepository r = new UserRepository(c);
                    User usr = r.GetUserByPseudo(HttpContext.User.Identity.Name);
                    usr.Nom = rm.Nom;
                    usr.Prenom = rm.Prenom;
                    usr.Email = rm.Email;
                    usr.Pseudo = rm.Pseudo;
                    usr.Mdp = usr.Mdp;
                    c.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }

            return View("Edit");
        }


        [HttpGet, Route("Profile/Subscribe/{pseudo}")]
        public ActionResult Subscribe(string pseudo)
        {
            using (var c = new Context.M2LinkContext())
            {
                UserRepository r = new UserRepository(c);
                User usr = r.GetUserByPseudo(pseudo);
                if (usr == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                User me = r.GetUserByPseudo(HttpContext.User.Identity.Name);
                if (me == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                me.Following.Add(usr);
                c.SaveChanges();
            }
            return RedirectToAction("Index", "AllProfiles");
        }

        [HttpGet, Route("Profile/Unsubscribe/{pseudo}")]
        public ActionResult Unsubscribe(string pseudo)
        {
            using (var c = new Context.M2LinkContext())
            {
                UserRepository r = new UserRepository(c);
                User usr = r.GetUserByPseudo(pseudo);
                if (usr == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                User me = r.GetUserByPseudo(HttpContext.User.Identity.Name);
                if (me == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                me.Following.Remove(usr);
                c.SaveChanges();
            }
            return RedirectToAction("Index", "AllProfiles");
        }
    }
}