using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class Variant
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? Weight { get; set; }
        public string SKU { get; set; }
        public bool? TrackInventory { get; set; }
        public bool? AllowPurchase { get; set; }
        public int? StockLevel { get; set; }
        public int? Position { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
    }
}
