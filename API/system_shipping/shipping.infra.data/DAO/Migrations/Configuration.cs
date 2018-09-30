using shipping.infra.data.DAO.Context;
using System.Data.Entity.Migrations;

namespace shipping.infra.data.DAO.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PostgressContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }


    }
}
