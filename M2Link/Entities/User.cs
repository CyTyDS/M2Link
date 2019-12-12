using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M2Link.Entities
{
    public class User
    {
        [KeyAttribute]
        public Guid UserId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }

        public string Pseudo { get; set; }

        public string Mdp { get; set; }
    }
}