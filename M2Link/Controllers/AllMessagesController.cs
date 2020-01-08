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
    public class AllMessagesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            AllMessagesModel apm = new AllMessagesModel
            {
                Messages = new List<MessageModel>()
            };
            using (var c = new Context.M2LinkContext())
            {
                UserRepository r = new UserRepository(c);
                User me = r.GetUserByPseudo(HttpContext.User.Identity.Name);

                foreach (User usr in me.Following)
                {
                    foreach (Message msg in usr.Messages)
                    {
                        MessageModel mm = new MessageModel
                        {
                            Content = msg.Content,
                            User = usr.Pseudo
                        };

                        apm.Messages.Add(mm);
                    }
                }
            }
            return View("SubsMsg", apm);
        }
    }
}