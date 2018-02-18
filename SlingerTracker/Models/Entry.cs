using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlingerTracker.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string UserReview { get; set; }

        public string DisplayText
        {
            get
            {
                return Name + " at " + Location;
            }
        }

    }
}