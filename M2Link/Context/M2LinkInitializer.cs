using M2Link.Entities;
using M2Link.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace M2Link.Context
{
    public class M2LinkInitializer : DropCreateDatabaseIfModelChanges<M2LinkContext>
    {
        protected override void Seed(M2LinkContext context)
        {
            User user = new User
            {
                UserId = Guid.NewGuid(),
                Prenom = "admin",
                Nom = "admin",
                Pseudo = "admin",
                Email = "admin.admin.fr",
                Mdp = BCrypt.Net.BCrypt.EnhancedHashPassword("admin", workFactor: 12)
            };

            Message msg = new Message
            {
                MessageId = Guid.NewGuid(),
                User = user,
                Content = ""
            };

            context.Users.Add(user);
            context.Messages.Add(msg);

            context.SaveChanges();
        }
    }
}