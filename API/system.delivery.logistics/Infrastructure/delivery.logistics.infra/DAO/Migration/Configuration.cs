using delivery.logistics.infra.DAO.Context;
using System.Data.Entity.Migrations;

namespace delivery.logistics.infra.DAO.Migration
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
