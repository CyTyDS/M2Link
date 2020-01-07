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
        [Required]
        [DisplayName("Pseudo")]
        public string Pseudo { get; set; }

        [Required]
        [DisplayName("Mot de passe")]
        public string Mdp { get; set; }
    }
}