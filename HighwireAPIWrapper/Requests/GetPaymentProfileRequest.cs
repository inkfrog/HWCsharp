using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetPaymentProfileRequest : HighwireGetRequest<GetPaymentProfileRequest>
    {
        public GetPaymentProfileRequest(int storeID, int profileID)
            : base(storeID, string.Format("ebay/payment_profiles/{0}.json", profileID))
        {
        }

        public GetPaymentProfileRequest(int profileID)
            : base(string.Format("ebay/payment_profiles/{0}.json", profileID))
        {
        }
    }
}
