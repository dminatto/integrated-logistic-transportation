using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.NameUser).IsRequired();

            Property(c => c.PasswordUser).IsRequired();
        }
    }
}
