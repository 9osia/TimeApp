using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeApp.Models
{
    public class Action : IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool IsRealized { get; set; }
        public int DurationTimeInMinutes { get; set; }
        public virtual Project Project { get; set; }
        public ICollection<SubAction> Subtasks { get; set; }
    }
}