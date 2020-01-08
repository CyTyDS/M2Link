using M2Link.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M2Link.Models
{
    public class ProfileModel
    {
        [Required]
        [DisplayName("Nom")]
        public string Nom { get; set; }

        [Required]
        [DisplayName("Prenom")]
        public string Prenom { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Pseudo")]
        public string Pseudo { get; set; }

        [Required]
        [DisplayName("Mot de passe")]
        public string Mdp { get; set; }

        [DisplayName("Messages")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}