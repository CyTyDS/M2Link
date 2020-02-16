using M2Link.Entities;
using M2Link.Models;
using M2Link.Repositories;
using System.Web.Mvc;
using System.Web.Security;
using BCrypt.Net;

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
                User u = null;
                using (var c = new Context.M2LinkContext())
                {
                    UserRepository r = new UserRepository(c);
                    //test si l'user n'appartient pas au registre des users
                    u = r.GetUserByPseudo(rm.Pseudo);
                }
                    
                if (u == null)
                {
                    ModelState.AddModelError("Login", "Le pseudo entré n'est pas enregistré dans la base de données.");
                    return View("Login");
                }

                if (!BCrypt.Net.BCrypt.EnhancedVerify(rm.Mdp, u.Mdp))
            
                {
                    ModelState.AddModelError("Mdp", "Votre mot de passe est incorrect.");
                    return View("Login");
                }
            }

            if (ModelState.IsValid)
            {
                //Ici, l'user est dans la DB

                FormsAuthentication.SetAuthCookie(rm.Pseudo, true);
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }
    }
}