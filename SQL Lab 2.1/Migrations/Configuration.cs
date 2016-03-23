namespace SQL_Lab_2._1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SQL_Lab_2._1.DepartmentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SQL_Lab_2._1.DepartmentDbContext context)
        {
            var kevin = new Developer()
            {
                Name = "Kevin Mach",
                Email = "ABC@gmail.com",
                StartDate = new DateTime(2000, 03, 30)
            };

            var seth = new Developer()
            {
                Name = "Seth Malloy",
                Email = "hep@gmail.com",
                StartDate = new DateTime(2000, 08, 21)
            };








        }
    }
}
