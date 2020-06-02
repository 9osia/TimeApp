using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeApp.Models
{
    public class Project : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskCounter { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}