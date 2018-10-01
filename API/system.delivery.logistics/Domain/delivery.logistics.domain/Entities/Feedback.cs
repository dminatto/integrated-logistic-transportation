using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delivery.logistics.domain.Entities
{
    public class Feedback : BaseEntity
    {
        public int Rating { get; set; }
        public string Note { get; set; }
    }
}
