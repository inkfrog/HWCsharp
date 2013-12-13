using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class PaymentProfile
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public bool? Default { get; set; }
        public int? SiteID { get; set; }
        public bool? Product_Profile { get; set; }
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
        public string SalesTaxState { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public bool? ShippingIncludedInTax { get; set; }
        public string PaymentInstructions { get; set; }
        public long? BusinessProfileID { get; set; }
    }
}
