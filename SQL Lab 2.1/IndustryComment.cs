using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
    public class IndustryComment
    { 
        public int Id { get; set; }
        public string Comment { get; set; }


        public virtual Developer Developer { get; set; }
        [Required]
        public virtual Industry Industry { get; set; }
    }
}
