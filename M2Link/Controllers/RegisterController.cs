using M2Link.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (rm.Mdp.Length < 8)
            {
                ModelState.AddModelError("Mdp", "Le mot de passe est trop faible");
                return View("Form", rm);
            }
            return View("Form");
        }
    }
}