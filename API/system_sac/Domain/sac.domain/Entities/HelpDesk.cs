using System.Collections.Generic;

namespace sac.domain.Entities
{
    public class HelpDesk : BaseEntity
    {
        public int IdUsuario { get; set; }
        public int ListTikets { get; set; }
        //public List<Tiket> ListTikets { get; set; }
    }
}
