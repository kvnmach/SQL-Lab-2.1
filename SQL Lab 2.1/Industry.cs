using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lab_2._1
{
    public   class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
        public virtual ICollection<IndustryComment> IndustryComments { get; set; } = new List<IndustryComment>(); 
    }
}
