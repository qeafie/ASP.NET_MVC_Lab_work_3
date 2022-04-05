﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_MVC_Lab_3.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }


        public List<Order> Orders{get; set;}
    }
}