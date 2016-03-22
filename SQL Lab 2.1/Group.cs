using System.Collections.Generic;

namespace SQL_Lab_2._1
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>(); 
    }
}