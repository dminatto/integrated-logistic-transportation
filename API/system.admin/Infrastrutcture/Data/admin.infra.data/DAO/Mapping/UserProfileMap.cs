using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public void Configure()
        {
            ToTable("user_map");

            HasKey(c => c.Id);

            Property(c => c.NameUserProfile).IsRequired();
        }
    }
}
