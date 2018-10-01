using System.Collections.Generic;

namespace delivery.logistics.domain.Entities
{
    public class DeliveryOrder : BaseEntity
    {
        public int IdOrder { get; set; }
        public string TokenOrder { get; set; }
        public List<DeliveryProgress> DeliveryProgresseList { get; set; }
    }
}
