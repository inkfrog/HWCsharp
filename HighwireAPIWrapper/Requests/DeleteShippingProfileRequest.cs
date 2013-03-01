using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteShippingProfileRequest : HighwireRequest
    {
        public DeleteShippingProfileRequest(int storeID, int profileID)
            : base(storeID, eHttpMethod.Delete, string.Format("ebay/shipping_profiles/{0}.json", profileID))
        {
        }

        public DeleteShippingProfileRequest(int profileID)
            : base(eHttpMethod.Delete, string.Format("ebay/shipping_profiles/{0}.json", profileID))
        {
        }
    }
}
