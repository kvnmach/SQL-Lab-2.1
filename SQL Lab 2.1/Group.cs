using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SQL_Lab_2._1
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>(); 
    }
}