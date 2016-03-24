using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public virtual Project Project { get; set; } 
        public virtual TimeEntry Time { get; set; }
    }
}
