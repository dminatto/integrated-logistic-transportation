using System;
using System.Collections.Generic;

namespace delivery.logistics.domain.Dto
{
    public class TravelAgenda
    {
        public int Id { get; set; }
        public DateTime DateTravel { get; set; }
        public List<CollectionOrder> CollectionOrderList { get; set; }

        //others atributes oculted...
    }
}
