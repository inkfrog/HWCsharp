﻿using System;
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
        public string Title { get; set; }
        public int MarketplaceID { get; set; }
        public int Amazon_UserID { get; set; }
        public int? Amazon_ProductID { get; set; }
        public string ASIN { get; set; }
        public long PrimaryBrowseNodeID { get; set; }
    }
}