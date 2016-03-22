using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
    public class ClientComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public virtual Client Client { get; set; } = new Client();
        public virtual Developer Developer { get; set; } = new Developer();
    }
}
