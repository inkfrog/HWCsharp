using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllShippingProfilesRequest : HighwireGetRequest<GetAllShippingProfilesRequest>
    {
        public GetAllShippingProfilesRequest(int storeID)
            : base(storeID, "ebay/shipping_profiles.json")
        {
        }

        public GetAllShippingProfilesRequest()
            : base("ebay/shipping_profiles.json")
        {
        }
    }
}
