using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditPaymentProfileRequest : HighwirePostOrPutRequest<PaymentProfile>
    {
        public EditPaymentProfileRequest(int storeID, PaymentProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/payment_profiles.json")
        {
        }

        public EditPaymentProfileRequest(PaymentProfile profileData)
            : base(profileData, eHttpMethod.Post, "ebay/payment_profiles.json")
        {
        }
    }
}
