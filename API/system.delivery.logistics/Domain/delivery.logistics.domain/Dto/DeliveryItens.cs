using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delivery.logistics.domain.Dto
{
    public class DeliveryItens
    {
        public int Id { get; set; }
        public int IdCollectionOrder { get; set; }
        public string NameItem { get; set; }

        //others atributes oculted...
    }
}
