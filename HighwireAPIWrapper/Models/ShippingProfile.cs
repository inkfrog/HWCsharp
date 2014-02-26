using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HighwireAPIWrapper.Models
{
    public class ShippingProfile
    {
        public int? ID { get; set; }
        public int? SiteID { get; set; }
        public string Name { get; set; }
        public string ShippingType { get; set; }
        public string PackageType { get; set; }
        public decimal? Dimensions_Depth { get; set; }
        public decimal? Dimensions_Length { get; set; }
        public decimal? Dimensions_Width { get; set; }
        public string Domestic_Type { get; set; }
        public string Domestic_Service1_Name { get; set; }
        public string Domestic_Service1_Cost1 { get; set; }
        public string Domestic_Service1_Cost2 { get; set; }
        public bool? Domestic_Service1_FreeShip { get; set; }
        public string Domestic_Service2_Name { get; set; }
        public string Domestic_Service2_Cost1 { get; set; }
        public string Domestic_Service2_Cost2 { get; set; }
        public bool? Domestic_Service2_FreeShip { get; set; }
        public string Domestic_Service3_Name { get; set; }
        public string Domestic_Service3_Cost1 { get; set; }
        public string Domestic_Service3_Cost2 { get; set; }
        public bool? Domestic_Service3_FreeShip { get; set; }
        public decimal? Domestic_HandlingCost { get; set; }
        public string Inter_Type { get; set; }
        public string Inter_Service1_Locations { get; set; }
        public string Inter_Service1_Name { get; set; }
        public string Inter_Service1_Cost1 { get; set; }
        public string Inter_Service1_Cost2 { get; set; }
        public bool? Inter_Service1_FreeShip { get; set; }
        public string Inter_Service2_Locations { get; set; }
        public string Inter_Service2_Name { get; set; }
        public string Inter_Service2_Cost1 { get; set; }
        public string Inter_Service2_Cost2 { get; set; }
        public string Inter_Service3_Locations { get; set; }
        public string Inter_Service3_Name { get; set; }
        public string Inter_Service3_Cost1 { get; set; }
        public string Inter_Service3_Cost2 { get; set; }
        public decimal? Inter_HandlingCost { get; set; }
        public string Dispatch_Time { get; set; }
        public bool? GetItFast { get; set; }
        public bool? Default { get; set; }
        public bool? ReturnPolicy { get; set; }
        public string Return_Within { get; set; }
        public string Return_Refund_As { get; set; }
        public string Return_Actor { get; set; }
        public string Return_Details { get; set; }
        public string Location_Country { get; set; }
        public string Location_Zip { get; set; }
        public string Location_Description { get; set; }
        public bool? Product_Profile { get; set; }
        public long? Flat_Discount_Profile_ID { get; set; }
        public long? Calculated_Discount_Profile_ID { get; set; }
        public bool? Promotional_Discount_Profile { get; set; }
        public long? Intl_Flat_Discount_Profile_ID { get; set; }
        public long? Intl_Calculated_Discount_Profile_ID { get; set; }
        public bool? Intl_Promotional_Discount_Profile { get; set; }
        public bool Global_Shipping { get; set; }
        public long? BusinessProfileID { get; set; }
        public string Ship_To_Locations { get; set; }
    }
}
