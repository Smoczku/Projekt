using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Strawberry.Web.Models
{
    public class Assignment
    {
        
        public Assignment()
        {
            Assigned = DateTime.Now;
            State = State.New;
        }

        public int AssignmentId { get; set; }

   //     [Required]
    //    public string UserProfileId { get; set; }

        public int TaskId { get; set; }

        // if assigned to group
        // assign to every user in group and add that group ID
        // displayed state of this task is the lowest possible
        public int? GroupId { get; set; }

        public State State { get; set; }

        public DateTime Assigned { get; set; }

        public virtual UserProfile User { get; set; }
        public virtual MyTask Task { get; set; }
        public virtual Group Group { get; set; }
    }

    public enum State
    {
        [Display(Name = "Nowe")]
        New = 0,
        [Display(Name = "Zaakceptowane")]
        Accepted = 1,
        [Display(Name = "Odrzucone")]
        Declined = 2,
        [Display(Name = "Usunięte")]
        Deleted = 3,
        [Display(Name = "Wykonane")]
        Done = 4
    }
}
