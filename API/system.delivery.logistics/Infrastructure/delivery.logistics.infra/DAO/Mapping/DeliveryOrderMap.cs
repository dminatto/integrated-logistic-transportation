using System.Data.Entity.ModelConfiguration;
using delivery.logistics.domain.Entities;

namespace delivery.logistics.infra.DAO.Mapping
{
    public class DeliveryOrderMap : EntityTypeConfiguration<DeliveryOrder>
    {
        public DeliveryOrderMap()
        {
            HasKey(e => e.Id);

            Property(e => e.TokenOrder).IsRequired();
            
        }
    }
}
