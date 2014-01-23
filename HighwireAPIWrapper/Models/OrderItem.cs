using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class OrderItem
    {
        public string Product_Title { get; set; }
        public string Thumb_Nail { get; set; }
        public int? ProductID { get; set; }
        public int? VariantID { get; set; }
        public string SKU { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public ProductOption[] Product_Options { get; set; }
        public decimal? Weight { get; set; }
        public bool? Checkout_Complete  { get; set; }
        public string eBay_ItemID { get; set; }
        public string eBay_TransactionID { get; set; }
        public string ShipTracking { get; set; }
        public decimal? HandlingCost { get; set; }
        public decimal? ShippingCost { get; set; }
        public string ShippingService { get; set; }
        public bool? IsExternalOrder { get; set; }
    }
}
