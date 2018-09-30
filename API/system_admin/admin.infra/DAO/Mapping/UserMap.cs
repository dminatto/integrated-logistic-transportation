using admin.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace system.infra.DAO.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.nameUser)
                   .IsRequired();

            builder.Property(c => c.passwordUser)
                   .IsRequired();
        }
    }
}
