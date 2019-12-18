using M2Link.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace M2Link.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public ActionResult Edit()
        {
            return View("Edit");
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
                return RedirectToAction("Index", "Home");
            }

            return View("Edit");
        }
    }
}