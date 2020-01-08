using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M2Link.WebServiceModels
{
    public class MessageModel
    {
        public string User { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid MessageId { get; set; }
    }
}