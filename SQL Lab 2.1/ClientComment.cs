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

        public virtual Client Clients { get; set; } = new Client();
        public virtual Developer Developers { get; set; } = new Developer();
    }
}
