using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AexSoftTest.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual Manager Manager { get; set; }
        public int ManagerID { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }

}
