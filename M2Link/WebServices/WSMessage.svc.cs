using M2Link.Entities;
using M2Link.Repositories;
using M2Link.WebServiceModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace M2Link.WebServices
{
    public class WSMessage : IWSMessage
    {
        public void DoWork()
        {
        }
        public Collection<MessageModel> GetMessages(Guid user)
        {
            if (user != null)
            {
                Context.M2LinkContext c = new Context.M2LinkContext();
                UserRepository r = new UserRepository(c);
                User u = r.GetUserByID(user);
                if (u != null)
                {
                    Collection<MessageModel> messages = new Collection<MessageModel>();
                    foreach (User following in u.Following)
                    {
                        ICollection<Message> curMessages = following.Messages;
                        foreach (Message mess in curMessages)
                        {
                            MessageModel messageM = new MessageModel
                            {
                                MessageId = mess.MessageId,
                                User = following.Pseudo,
                                Content = mess.Content,
                                UserId = u.UserId,

                            };
                            messages.Add(messageM);
                        }
                    }
                    return messages;
                }
            }
            return null;
        }
        public MessageModel CreateMessage(Guid user, string messageContent)
        {
            Context.M2LinkContext c = new Context.M2LinkContext();
            UserRepository r = new UserRepository(c);
            User u = r.GetUserByID(user);
            if (u != null)
            {
                MessageModel messageModel = new MessageModel
                {
                    MessageId = Guid.NewGuid(),
                    User = u.Pseudo,
                    UserId = u.UserId,
                    Content = messageContent
                    
                };
                MessageRepository mr = new MessageRepository(c);
                Message msg = new Message
                {
                    MessageId = messageModel.MessageId,
                    User = u,
                    Content = messageContent
                };
                u.Messages.Add(msg);
                mr.Add(msg);
                c.SaveChanges();
                return messageModel;
            }
            return null;
        }

    }
}
