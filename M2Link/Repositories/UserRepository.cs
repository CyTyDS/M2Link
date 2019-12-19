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
            this.context.Users.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

        public User GetUserByID(int id)
        {
            return this.context.Users.Find(id);
        }
        public User GetUserByPseudo(string pseudo)
        {
            try
            {
                return this.context.Users.Where(q => q.Pseudo == pseudo).First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Message> GetAllMessagesOfUser(string pseudo)
        {
            User u = this.GetUserByPseudo(pseudo);
            if (u == null)
            {
                return null;
            }
            return u.Messages;
        }
    }
}