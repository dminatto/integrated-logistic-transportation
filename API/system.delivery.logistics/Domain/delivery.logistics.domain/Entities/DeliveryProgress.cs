using System.Collections.Generic;

namespace delivery.logistics.domain.Entities
{
    public enum Status
    {
        ITEM_COLLECTED = 1,
        ITEM_MISGUIDED = 2,
        ITEM_DELIVERED = 3,
        RECIPIENT_ABSENT = 4
    }

    public class DeliveryProgress : BaseEntity
    {
        public int IdDeliveryOrder { get; set; } 
        public int StatusDelivery { get; set; }
        public List<LocationTravel> LocationTravelList { get; set; }
    }
}
