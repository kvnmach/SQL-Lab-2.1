﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual Industry Industry { get; set; } = new Industry(); 

    }
}
