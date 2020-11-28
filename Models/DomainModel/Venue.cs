using System;
using System.Collections.Generic;

#nullable disable

namespace EventApp.Models.DomainModel
{
    public partial class Venue
    {
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public string VenueContactInfo { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}
