using delivery.logistics.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delivery.logistics.infra.DAO.Mapping
{
    public class DeliveryProgressMap : EntityTypeConfiguration<DeliveryProgress>
    {
        public DeliveryProgressMap()
        {
            HasKey(e => e.Id);

            Property(e => e.IdDeliveryOrder).IsRequired();

            Property(e => e.StatusDelivery).IsRequired();
        }
    }
}
