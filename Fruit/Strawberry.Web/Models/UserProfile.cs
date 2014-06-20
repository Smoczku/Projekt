using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Strawberry.Web.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            this.DateCreated = DateTime.Now;
            Groups = new List<Group>();
            Assignments = new List<Assignment>(); 
        }

        public int UserProfileId { get; set; }

        [StringLength(64)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [StringLength(64)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [StringLength(128)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(64)]
        [Display(Name = "Stanowisko")]
        public string Position { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Utworzony")]
        public DateTime DateCreated { get; set; }

        public string ApplicationUserID { get; set; }

        public virtual ApplicationUser Account { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual  ICollection<Assignment> Assignments { get; set; }

    }
}