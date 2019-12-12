using M2Link.Context;
using M2Link.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M2Link.Repositories
{
    public class UserRepository
    {
        private M2LinkContext context;

        public UserRepository(M2LinkContext context) {
            this.context = context;
        }

        public void Add(User user)
        {
            this.context.User.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return context.User;
        }

        public User GetUserByID(int id)
        {
            return this.context.User.Find(id);
        }
    }
}