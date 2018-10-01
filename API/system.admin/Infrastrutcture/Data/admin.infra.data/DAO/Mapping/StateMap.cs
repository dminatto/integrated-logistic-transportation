using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.NameState).IsRequired();
        }
    }
}
