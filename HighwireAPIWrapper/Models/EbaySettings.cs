using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class EbaySettings
    {
        public int? ID { get; set; }
        public int? ProductID { get; set; }
        public int? GeneralProfile_ID { get; set; }
        public int? ShippingProfile_ID { get; set; }
        public string Title { get; set; }
        public int? Ebay_SiteID { get; set; }
        public string Currency { get; set; }
        public int? Ebay_Account { get; set; }
        public bool? Pay_PayPal { get; set; }
        public string Pay_PayPalEmail { get; set; }
        public bool? Pay_VisaMC { get; set; }
        public bool? Pay_Amex { get; set; }
        public bool? Pay_ProPay { get; set; }
        public bool? Pay_MoneyBookers { get; set; }
        public bool? Pay_PayMate { get; set; }
        public bool? Pay_IntegratedCC { get; set; }
        public bool? Pay_Discover { get; set; }
        public bool? Pay_POD { get; set; }
        public bool? Pay_Other { get; set; }
        public bool? Pay_SeeDescription { get; set; }
        public bool? Pay_PayImmediately { get; set; }
        public bool? Buyer_AllowAll { get; set; }
        public bool? Buyer_NoPayPal { get; set; }
        public bool? Buyer_Unpaid { get; set; }
        public int? Buyer_Unpaid_StrikeCount { get; set; }
        public string Buyer_Unpaid_Days { get; set; }
        public bool? Buyer_Country { get; set; }
        public bool? Buyer_Policy { get; set; }
        public string Buyer_Policy_Count { get; set; }
        public string Buyer_Policy_Days { get; set; }
        public bool? Buyer_Feedback { get; set; }
        public string Buyer_Feedback_Score { get; set; }
        public string SalesTaxState { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public bool? ShippingIncludedInTax { get; set; }
        public bool? ReturnPolicy { get; set; }
        public string Return_Within { get; set; }
        public string Return_Refund_As { get; set; }
        public string Return_Actor { get; set; }
        public string Return_Details { get; set; }
        public string PaymentInstructions { get; set; }
        public long? StoreCategory1 { get; set; }
        public long? StoreCategory2 { get; set; }
    }
}
