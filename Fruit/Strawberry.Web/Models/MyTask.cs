
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry.Web.Models
{
    public class MyTask
    {
        public MyTask()
        {
            Assignments = new List<Assignment>();
            DateCreated = DateTime.Now;
        }

        public int MyTaskId { get; set; }

        [Required]
        [StringLength(64)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        [Required]
        public Priority Priority { get; set; }

        // TimeStamps

        [DataType(DataType.Date)]
        public DateTime? DateDone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateAccepted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateCreated { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateDeclined { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }

    }

    public enum Priority
    {
        [Display(Name = "Wysoki")]
        High = 0,
        [Display(Name = "Średni")]
        Medium = 1,
        [Display(Name = "Niski")]
        Low = 2
    }
}
