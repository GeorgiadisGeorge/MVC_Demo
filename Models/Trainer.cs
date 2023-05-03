using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class Trainer
    {
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<string> Skills { get; set; }

        public Trainer()
        {
            Skills = new List<string>();
        }

        public Trainer(int id, string firstName, string lastName, string email, string phoneNumber, List<string> skills)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Skills = skills;
        }
    }


}