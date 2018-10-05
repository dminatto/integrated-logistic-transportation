using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public void Configure()
        {
            ToTable("customer");

            HasKey(c => c.Id);

            Property(c => c.NameCustomer).IsRequired();

            Property(c => c.EmailCustomer).IsRequired();

            Property(c => c.CpfCustomer).IsRequired();

            Property(c => c.PhoneCustomer).IsRequired();

            Property(c => c.CepCustomer).IsRequired();

            Property(c => c.AddressCustomer).IsRequired();

        }
    }
}
