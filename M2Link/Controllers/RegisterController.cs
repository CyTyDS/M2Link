using M2Link.Entities;
using M2Link.Models;
using M2Link.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace M2Link.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register/Form
        [HttpGet]
        public ActionResult Form()
        {
            return View("Form");
        }

        // Post: Register/Form
        [HttpPost]
        public ActionResult Form(RegisterModel rm)
        {
            //TODO Verify if pseudo already exists
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

                    if (rm.VerifMDP != null)
                    {
                        if (!rm.Mdp.Equals(rm.VerifMDP))
                        {
                            ModelState.AddModelError("VerifMDP", "Le Mot de passe n'a pas été réécrit correctement.");
                            return View("Form");
                        }
                    }
                }
            }
            
            if (ModelState.IsValid)
            {
                /*Context.M2LinkContext c = new Context.M2LinkContext();
                UserRepository r = new UserRepository(c);
                r.GetAll();
                c.SaveChanges();*/

                using (var c = new Context.M2LinkContext())
                {
                    UserRepository r = new UserRepository(c);
                    User us = new User
                    {
                        UserId = Guid.NewGuid(),
                        Prenom = rm.Prenom,
                        Nom = rm.Nom,
                        Pseudo = rm.Pseudo,
                        Email = rm.Email,
                        Mdp = rm.Mdp
                    };
                    r.Add(us);
                    c.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }

            return View("Form");
        }
    }
}