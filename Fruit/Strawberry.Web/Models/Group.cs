using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry.Web.Models
{
    public class Group
    {
        public Group()
        {
            Users = new List<UserProfile>();
            Assignments = new List<Assignment>();
        }

        public int GroupId { get; set; }

        [Required]
        [StringLength(64)]
        [Display(Name="Nazwa")]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        public virtual ICollection<UserProfile> Users { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
