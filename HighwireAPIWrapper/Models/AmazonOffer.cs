using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class AmazonOffer
    {
        public int? ID { get; set; }
        public string Price_Method { get; set; }
        public string Price_PlusMinus { get; set; }
        public string Price_ModifyType { get; set; }
        public decimal? Price_ModifyAmount { get; set; }
        public string SalePrice_Method { get; set; }
        public string SalePrice_PlusMinus { get; set; }
        public string SalePrice_ModifyType { get; set; }
        public decimal? SalePrice_ModifyAmount { get; set; }
        public DateTime? SaleStartDate { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public decimal? Price_CustomAmount { get; set; }
        public decimal? SalePrice_CustomAmount { get; set; }
        public string Condition { get; set; }
        public string Condition_Note { get; set; }
        public int Quantity { get; set; }
        public int? Handling_Time { get; set; }
        public DateTime? Restock_Date { get; set; }
        public string Import_Designation { get; set; }
        public string Country_As_Labeled { get; set; }
        public bool Amazon_Fulfillment { get; set; }
        public bool Gift_Wrap { get; set; }
        public bool Gift_Message { get; set; }
        public bool Shared_Offer { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
    }
}
