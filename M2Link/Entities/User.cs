using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace M2Link.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Pseudo { get; set; }
        public string Mdp { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<User> Following { get; set; }
    }
}