using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetShippingProfileRequest : HighwireGetRequest<GetShippingProfileRequest>
    {
        public GetShippingProfileRequest(int storeID, int profileID)
            : base(storeID, string.Format("ebay/shipping_profiles/{0}.json", profileID))
        {
        }

        public GetShippingProfileRequest(int profileID)
            : base(string.Format("ebay/shipping_profiles/{0}.json", profileID))
        {
        }
    }
}
