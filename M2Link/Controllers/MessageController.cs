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
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Edit()
        {
            return View("Edit");
        }

        [HttpPost]
        public ActionResult Edit(MessageModel rm)
        {
            if (rm != null && rm.Content != null)
            {
                using (var c = new Context.M2LinkContext())
                {
                    UserRepository ur = new UserRepository(c);
                    MessageRepository mr = new MessageRepository(c);
                    User usr = ur.GetUserByPseudo(HttpContext.User.Identity.Name);
                    Message msg = new Message
                    {
                        MessageId = Guid.NewGuid(),
                        User = usr,
                        Content = rm.Content
                    };
                    usr.Messages.Add(msg);
                    mr.Add(msg);
                    c.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }

            return View("Edit");
        }
    }
}