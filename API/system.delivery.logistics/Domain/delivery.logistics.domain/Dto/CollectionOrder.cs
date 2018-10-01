using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delivery.logistics.domain.Dto
{
    public class CollectionOrder
    {
        public int Id { get; set; }
        public string TokenOrder { get; set; }

        //others atributes oculted...

        public ReceivingAddress ReceivingAddressOrder { get; set; }
        public List<DeliveryItens> DeliveryItensList { get; set; }
    }
}
