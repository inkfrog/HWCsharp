using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllPaymentProfilesRequest : HighwireGetRequest<GetAllPaymentProfilesRequest>
    {
        public GetAllPaymentProfilesRequest(int storeID)
            : base(storeID, "ebay/payment_profiles.json")
        {
        }

        public GetAllPaymentProfilesRequest()
            : base("ebay/payment_profiles.json")
        {
        }
    }
}
