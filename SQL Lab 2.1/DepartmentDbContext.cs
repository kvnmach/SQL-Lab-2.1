namespace SQL_Lab_2._1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DepartmentDbContext : DbContext
    {
        // Your context has been configured to use a 'DepartmentDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SQL_Lab_2._1.DepartmentDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DepartmentDbContext' 
        // connection string in the application configuration file.
        public DepartmentDbContext()
            : base("name=DepartmentDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Developer> Developers { get; set; }
    }

    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
        public virtual ICollection<ClientComment> ClientComments { get; set; } = new List<ClientComment>();
        public virtual ICollection<ProjectComment> ProjectComments { get; set; } = new List<ProjectComment>();
        public virtual ICollection<IndustryComment> IndustryComments { get; set; } = new List<IndustryComment>();
    }


}