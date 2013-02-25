using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class Product
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShippingMethod { get; set; }
        public decimal? ShippingFee { get; set; }
        public decimal? ShippingFeeAdditional { get; set; }
        public decimal? Handlingfee { get; set; }
        public decimal? ShippingFee_Int { get; set; }
        public decimal? ShippingFeeAdditional_Int { get; set; }
        public decimal? HandlingFee_Int { get; set; }
        public decimal? HandlingFeeAdditional_Int { get; set; }
        public decimal? ShippingFee_Custom { get; set; }
        public decimal? HandlingFee_Custom { get; set; }
        public decimal? HandlingFeeAdditional_Custom { get; set; }
        public string SEO_PageTitle { get; set; }
        public string SEO_Keywords { get; set; }
        public string SEO_Description { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsDigital { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsFeatured { get; set; }
        public bool? IsOnSale { get; set; }
        public string URLHandle { get; set; }
        public bool? CrossPromoteCategory { get; set; }
        public bool? MultiOptionInventoryTracking { get; set; }
        public string OptionName1 { get; set; }
        public string OptionName2 { get; set; }
        public string OptionName3 { get; set; }
        public string OptionName4 { get; set; }
        public string OptionName5 { get; set; }
        public string OptionValues1 { get; set; }
        public string OptionValues2 { get; set; }
        public string OptionValues3 { get; set; }
        public string OptionValues4 { get; set; }
        public string OptionValues5 { get; set; }
        public Image[] Images { get; set; }
        public Variant[] Variants { get; set; }
        public Category[] Categories { get; set; }
        public bool Channel_Ebay { get; set; }
        public bool Channel_Highwire { get; set; }
        public bool Channel_Google { get; set; }
        public bool Channel_Bonanza { get; set; }
        public bool Channel_Bing { get; set; }
        public bool Channel_Amazon { get; set; }
    }
}
