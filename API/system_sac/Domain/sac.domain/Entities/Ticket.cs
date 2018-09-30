using System.Collections.Generic;

namespace sac.domain.Entities
{
    public class Ticket : BaseEntity
    {
        public int StatusTicket { get; set; }
        public int IdCustomer { get; set; }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public string TokenOrder { get; set; }
        public int CategoryTiket { get; set; }
        public int RatingTicket { get; set; }
        // public List<InteractionTicket> Interactions { get; set; }
        public int Interactions { get; set; }

    }
}
