using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<ProjectComment> ProjectComments { get; set; } = new List<ProjectComment>();
        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>(); 
             
    }

}
