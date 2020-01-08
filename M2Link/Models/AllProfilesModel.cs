using M2Link.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M2Link.Models
{
    public class AllProfilesModel
    {
        //Boolean is the answer to "Do I follow this user ?"
        public IDictionary<User, Boolean> Users { get; set; }
    }
}