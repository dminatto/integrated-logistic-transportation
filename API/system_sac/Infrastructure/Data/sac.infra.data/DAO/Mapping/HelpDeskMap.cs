using sac.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace sac.infra.data.DAO.Mapping
{
    public class HelpDeskMap : EntityTypeConfiguration<HelpDesk>
    {
        public HelpDeskMap()
        {
            HasKey(e => e.Id);

            Property(e => e.IdUsuario).IsRequired();

            Property(e => e.ListTikets).IsRequired();
        }
    }
}
