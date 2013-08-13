using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class AmazonSettings
    {
        public int? ID { get; set; }
        public int ProductID { get; set; }
        public int OfferID { get; set; }
        public int MarketplaceID { get; set; }
        public int Amazon_UserID { get; set; }
        public int? Amazon_ProductID { get; set; }
        public string Seller_SKU { get; set; }
    }
}
