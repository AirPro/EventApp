using System;
using System.Collections.Generic;

#nullable disable

namespace EventApp.Models.DomainModel
{
    public partial class Event
    {
        public Event()
        {
            Promoters = new HashSet<Promoter>();
            Venues = new HashSet<Venue>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventCity { get; set; }
        public DateTime EventDate { get; set; }

        public virtual ICollection<Promoter> Promoters { get; set; }
        public virtual ICollection<Venue> Venues { get; set; }
    }
}
