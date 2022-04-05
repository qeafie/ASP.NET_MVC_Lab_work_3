using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_MVC_Lab_3.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string User { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}