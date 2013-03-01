using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteListingProfileRequest : HighwireRequest
    {
        public DeleteListingProfileRequest(int storeID, int profileID)
            : base(storeID, eHttpMethod.Delete, string.Format("ebay/listing_profiles/{0}.json", profileID))
        {
        }

        public DeleteListingProfileRequest(int profileID)
            : base(eHttpMethod.Delete, string.Format("ebay/listing_profiles/{0}.json", profileID))
        {
        }
    }
}
