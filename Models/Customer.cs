using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sk611715MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }

        //connect the tables
        public ICollection<Orders> Orders { get; set; }
    }
}