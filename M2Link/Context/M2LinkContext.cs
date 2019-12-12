using M2Link.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace M2Link.Context
{
    public class M2LinkContext : DbContext
    {
        public M2LinkContext() : base("M2LinkContext") {
            Database.SetInitializer<M2LinkContext>(new M2LinkInitializer());
        }

        public DbSet<User> User { get; set; }
    }
}