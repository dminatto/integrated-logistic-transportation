using sac.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace sac.infra.data.DAO.Mapping
{
    public class TicketMap : EntityTypeConfiguration<Tikcet>
    {
        public TicketMap()
        {
            HasKey(e => e.Id);

            Property(e => e.StatusTicket).IsRequired();

            Property(e => e.NameCustomer).IsRequired();

            Property(e => e.PhoneCustomer).IsRequired();

            Property(e => e.EmailCustomer).IsRequired();

            Property(e => e.TokenOrder).IsOptional();

            Property(e => e.CategoryTiket).IsRequired();

            Property(e => e.RatingTicket).IsOptional();

            Property(e => e.Interactions).IsRequired();

        }

    }
}
