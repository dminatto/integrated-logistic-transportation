using System.Data.Entity.ModelConfiguration;
using delivery.logistics.domain.Entities;

namespace delivery.logistics.infra.DAO.Mapping
{
    public class FeedbackMap : EntityTypeConfiguration<Feedback>
    {
        public FeedbackMap()
        {
            HasKey(e => e.Id);

            Property(e => e.Rating).IsRequired();

            Property(e => e.Note).IsOptional();
        }
    }
}
