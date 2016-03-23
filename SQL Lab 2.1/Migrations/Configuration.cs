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
        //make new developers using faker
        //add clients
        //add projects 
        //add industry
        //
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

            var katy = new Developer()
            {
                Name = "Katy Sims",
                Email = "aaa@aol.com",
                StartDate = new DateTime(2000, 12, 25)
            };

            var teee = new Developer()
            {
                Name = "Jon Doe",
                Email = "dddd@aol.com",
                StartDate = new DateTime(2000, 02, 19)
            };

            context.Developers.AddOrUpdate(d => d.Name, kevin );

            var bee = new Group()
            {
                Name = "BackEnd"
            };
            bee.Developers.Add(kevin);
            bee.Developers.Add(teee);

            var fee = new Group()
            {
                Name = "FrontEnd"
            };
            fee.Developers.Add(katy);
            fee.Developers.Add(seth);

            context.Groups.AddOrUpdate(g=> g.Name, bee, fee);

            var client = new Client() {Name = "TIY"};










        }
    }
}
