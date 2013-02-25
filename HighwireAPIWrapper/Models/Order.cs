using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class Order
    {
        public int? ID { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Taxes { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Total { get; set; }
        public string Status { get; set; }
        public string Customer_ID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Payment_Received { get; set; }
        public string Payment_Method { get; set; }
        public string Payment_ID { get; set; }
        public string Shipping_Method { get; set; }
        public bool? Order_Shipped { get; set; }
        public string Shipping_Service { get; set; }
        public string Shipping_Tracking { get; set; }
        public decimal Total_Weight { get; set; }
        public string IP_Address { get; set; }
        public string Entry_Page { get; set; }
        public string Source { get; set; }
        public OrderLabel Order_Label { get; set; }
        public string Buyer_Note { get; set; }
        public string Internal_Note { get; set; }
        public OrderItem[] Order_Items { get; set; }
        public Address Billing_Address { get; set; }
        public Address Shipping_Address { get; set; }
    }
}
