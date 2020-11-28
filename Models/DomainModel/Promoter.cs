using System;
using System.Collections.Generic;

#nullable disable

namespace EventApp.Models.DomainModel
{
    public partial class Promoter
    {
        public int PromoterId { get; set; }
        public string PromoterName { get; set; }
        public string PromoterAddress { get; set; }
        public string PromoterContactInfo { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}
