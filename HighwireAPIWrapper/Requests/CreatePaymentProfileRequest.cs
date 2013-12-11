using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class CreatePaymentProfileRequest : HighwirePostOrPutRequest<PaymentProfile>
    {
        public CreatePaymentProfileRequest(int storeID, PaymentProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/payment_profiles.json")
        {
        }

        public CreatePaymentProfileRequest(PaymentProfile profileData)
            : base(profileData, eHttpMethod.Post, "ebay/payment_profiles.json")
        {
        }
    }
}
