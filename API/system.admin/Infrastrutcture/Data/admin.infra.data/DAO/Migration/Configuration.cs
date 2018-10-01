using admin.infra.data.DAO.Context;
using System.Data.Entity.Migrations;

namespace admin.infra.data.DAO.Migration
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
