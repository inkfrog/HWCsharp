using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HighwireAPIWrapper.Models
{
    public class ListingProfile
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public bool? Default { get; set; }
        public int? SiteID { get; set; }
        public int? TemplateID { get; set; }
        public string ListingType { get; set; }
        public string ListingDuration { get; set; }
        public int? PrimaryCatID { get; set; }
        public string PrimaryCatPath { get; set; }
        public bool? Reserve_Enabled { get; set; }
        public string Reserve_Method { get; set; }
        public string Reserve_PlusMinus { get; set; }
        public string Reserve_ModifyType { get; set; }
        public decimal? Reserve_ModifyAmount { get; set; }
        public decimal? Reserve_CustomAmount { get; set; }
        public bool? BIN_Enabled { get; set; }
        public string BIN_Method { get; set; }
        public string BIN_PlusMinus { get; set; }
        public string BIN_ModifyType { get; set; }
        public decimal? BIN_ModifyAmount { get; set; }
        public decimal? BIN_CustomAmount { get; set; }
        public bool? StartPrice_Enabled { get; set; }
        public string StartPrice_Method { get; set; }
        public string StartPrice_PlusMinus { get; set; }
        public string StartPrice_ModifyType { get; set; }
        public decimal? StartPrice_ModifyAmount { get; set; }
        public decimal? StartPrice_CustomAmount { get; set; }
        public bool? Catalog_Enabled { get; set; }
        public string Catalog_ProductID { get; set; }
        public string Catalog_ProductName { get; set; }
        public string Catalog_DetailsURL { get; set; }
        public string Catalog_StockImageURL { get; set; }
        public bool? Catalog_UseStockPhotoAsGallery { get; set; }
        public bool? Catalog_ShowStockPhoto { get; set; }
        public bool? Catalog_ShowDescription { get; set; }
        public bool? BestOffer { get; set; }
        public bool? Product_Profile { get; set; }
        public ItemSpecific[] Item_Specifics { get; set; }
        public int? Condition { get; set; }
        public bool? BestOffer_AutoAccept { get; set; }
        public decimal? BestOffer_AutoAccept_Price { get; set; }
        public bool? BestOffer_AutoDecline { get; set; }
        public decimal? BestOffer_AutoDecline_Price { get; set; }
        public string Currency { get; set; }
        public List<PartsCompatabilities> PartsCompatabilities { get; set; }
        public string Condition_Description { get; set; }
        public eAppendGalleryPreference? Append_Gallery_Preference { get; set; }
    }
}
