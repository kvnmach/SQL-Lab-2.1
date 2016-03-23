using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
   public class TimeEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Date { get; set; }
        public float TimeSpent { get; set; }
        public virtual Task Task { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual ICollection<Developer> Developers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }  
    }
}
