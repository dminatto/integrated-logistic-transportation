using sac.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace sac.infra.data.DAO.Mapping
{
    public class InteractionTiketMap : EntityTypeConfiguration<InteractionTicket>
    {
        public InteractionTiketMap()
        {
            HasKey(e => e.Id);

            Property(e => e.IdTicket).IsRequired();

            Property(e => e.IdUsuario).IsRequired();

            Property(e => e.NoteTicket).IsRequired();

        }

    }
}
