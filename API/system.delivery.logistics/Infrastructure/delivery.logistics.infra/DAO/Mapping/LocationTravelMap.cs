using delivery.logistics.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace delivery.logistics.infra.DAO.Mapping
{
    class LocationTravelMap : EntityTypeConfiguration<LocationTravel>
    {
        public LocationTravelMap()
        {
            HasKey(e => e.Id);

            Property(e => e.IdTravelAgenda).IsRequired();

            Property(e => e.Longitude).IsRequired();

            Property(e => e.Latitude).IsRequired();
        }
    }
}
