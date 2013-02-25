using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class Customer
    {
        public int? ID { get; set; }
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string Phone { get; set; }
        public DateTime Created_At { get; set; }
        public bool? Receive_Updates { get; set; }
        public Address Billing_Address { get; set; }
        public Address Shipping_Address { get; set; }
    }
}
