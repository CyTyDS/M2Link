using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M2Link.Models
{
    public class MessageModel
    {
        [Required]
        [DisplayName("User")]
        public string User { get; set; }

        [Required]
        [DisplayName("Message")]
        public string Content { get; set; }


    }
}