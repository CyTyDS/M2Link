using M2Link.Context;
using M2Link.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M2Link.Repositories
{
    public class MessageRepository
    {
        private M2LinkContext context;

        public MessageRepository(M2LinkContext context)
        {
            this.context = context;
        }

        public void Add(Message message)
        {
            this.context.Messages.Add(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return context.Messages;
        }

        public Message GetMessageByID(int id)
        {
            return this.context.Messages.Find(id);
        }

        public IEnumerable<Message> GetMessageOfUser(string pseudo)
        {
            try
            {
                return context.Messages.Where(q => q.User.Pseudo == pseudo);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}