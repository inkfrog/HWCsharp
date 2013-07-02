using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class AmazonProduct
    {
        public int? ID { get; set; }
        public decimal? MSRP { get; set; }
        public bool Manufacturer_Discontinued { get; set; }
        public string Manufacturer { get; set; }
        public string Brand_Name { get; set; }
        public string Model_Number { get; set; }
        public string MPN { get; set; }
        public string UPC_or_EAN { get; set; }
        public string SKU { get; set; }
        public int? Package_Quantity { get; set; }
        public double? Product_Dimensions_Length { get; set; }
        public double? Product_Dimensions_Height { get; set; }
        public double? Product_Dimensions_Width { get; set; }
        public string Product_Dimensions_Units { get; set; }
        public double? Shipping_Weight { get; set; }
        public string Shipping_Weight_Units { get; set; }
        public double? Package_Dimensions_Length { get; set; }
        public double? Package_Dimensions_Height { get; set; }
        public double? Package_Dimensions_Width { get; set; }
        public string Package_Dimensions_Units { get; set; }
        public int? Lithium_Ion_Battery_Count { get; set; }
        public int? Lithium_Metal_Battery_Count { get; set; }
        public int? Lithium_Ion_Cell_Count { get; set; }
        public int? Lithium_Metal_Cell_Count { get; set; }
        public int? Lithium_Watt_Hours { get; set; }
        public int? Lithium_Voltage { get; set; }
        public decimal? Lithium_Weight { get; set; }
        public string Lithium_Packaging { get; set; }
        public string Size { get; set; }
        public string Fur_Description { get; set; }
        public string Color { get; set; }
        public AmazonProductOption[] Product_Options { get; set; }
        public string Name { get; set; }
        public bool Shared_Product { get; set; }
        public string Author { get; set; }
        public string Binding { get; set; }
        public string Edition { get; set; }
        public bool Is_Autographed { get; set; }
        public bool Is_Memorabilia { get; set; }
        public int? Number_Of_Pages { get; set; }
        public DateTime? Publication_Date { get; set; }
        public string Publisher { get; set; }
        public DateTime? Release_Date { get; set; }
        public string Studio { get; set; }
        public string Currency { get; set; }
    }
}
