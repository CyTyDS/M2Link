using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace M2Link.Entities
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public Guid MessageId { get; set; }
        public virtual User User { get; set; }
        public string Content { get; set; }
    }
}