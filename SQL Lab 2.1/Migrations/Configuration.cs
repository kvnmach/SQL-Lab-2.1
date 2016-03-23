using System;
using System.Data.Entity.Migrations;

namespace SQL_Lab_2._1.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DepartmentDbContext>
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
        protected override void Seed(DepartmentDbContext context)
        {
            var kevin = new Developer
            {
                Name = "Kevin Mach",
                Email = "ABC@gmail.com",
                StartDate = new DateTime(2000, 03, 30)
            };

            var seth = new Developer
            {
                Name = "Seth Malloy",
                Email = "hep@gmail.com",
                StartDate = new DateTime(2000, 08, 21)
            };

            var katy = new Developer
            {
                Name = "Katy Sims",
                Email = "aaa@aol.com",
                StartDate = new DateTime(2000, 12, 25)
            };

            var teee = new Developer
            {
                Name = "Jon Doe",
                Email = "dddd@aol.com",
                StartDate = new DateTime(2000, 02, 19)
            };

            context.Developers.AddOrUpdate(d => d.Name, kevin);

            var bee = new Group
            {
                Name = "BackEnd"
            };
            bee.Developers.Add(kevin);
            bee.Developers.Add(teee);

            var fee = new Group
            {
                Name = "FrontEnd"
            };
            fee.Developers.Add(katy);
            fee.Developers.Add(seth);

            context.Groups.AddOrUpdate(g => g.Name, bee, fee);

            var client1 = new Client {Name = "TIY"};

            var firstproj = new Project
            {
                Name = "Sql Lab",
                Client = client1,
                Developers = {kevin, teee}
            };
            context.Projects.AddOrUpdate(p => p.Name, firstproj);

            var secproj = new Project
            {
                Name = "Sql Lab2",
                Client = client1,
                Developers = {katy, seth}
            };
            context.Projects.AddOrUpdate(p => p.Name, secproj);


            var comment = new IndustryComment
            {
                Comment = "Hello World"
            };

            var industry1 = new Industry
            {
                Name = "Cool",
                IndustryComments = {comment}
            };

            context.Industries.AddOrUpdate(x => x.Name, industry1);

            var time1 = new TimeEntry
            {
                Date = new DateTime(1000, 12, 01),
                TimeSpent = 1.0f,
                Developer = seth,
                Task = new Task
                {
                    Name = "1",
                    Project = firstproj
                }
            };

            var time2 = new TimeEntry
            {
                Date = new DateTime(2000, 12, 01),
                TimeSpent = 2.0f,
                Developer = katy,
                Task = new Task
                {
                    Name = "2",
                    Project = firstproj
                }
            };

            var time3 = new TimeEntry
            {
                Date = new DateTime(3000, 12, 01),
                TimeSpent = 3.0f,
                Developer = teee,
                Task = new Task
                {
                    Name = "3",
                    Project = firstproj
                }
            };

            var time4 = new TimeEntry
            {
                Date = new DateTime(4000, 12, 01),
                TimeSpent = 4.0f,
                Developer = seth,
                Task = new Task
                {
                    Name = "1",
                    Project = secproj
                }
            };

            var time5 = new TimeEntry
            {
                Date = new DateTime(5000, 12, 01),
                TimeSpent = 5.0f,
                Developer = kevin,
                Task = new Task
                {
                    Name = "5",
                    Project = secproj
                }
            };
            context.TimeEntries.AddOrUpdate(c=> c.Date, time1, time2, time3, time4, time5);
            context.Industries.AddOrUpdate(b => b.IndustryComments, industry1);
            
        }
    }
}