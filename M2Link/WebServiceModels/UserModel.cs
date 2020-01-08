using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M2Link.WebServiceModels
{
    public class UserModel
    {
     
        public string Pseudo { get; set; }
        public Guid UserId { get; set; }
    }
}