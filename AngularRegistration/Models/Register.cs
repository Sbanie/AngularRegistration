using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularRegistration.Models
{
    public class Register
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateTimeCreated { get; set; }
    }
}