﻿using M2Link.Entities;
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
                Prenom = "toto",
                Nom = "titi",
                Pseudo = "PyTy",
                Email = "oki@doki.io",
                Mdp = "Chocolat*123"
            };

            context.Users.Add(user);

            context.SaveChanges();
        }
    }
}