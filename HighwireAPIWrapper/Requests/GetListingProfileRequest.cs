using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetListingProfileRequest : HighwireGetRequest<GetListingProfileRequest>
    {
        public GetListingProfileRequest(int storeID, int profileID)
            : base(storeID, string.Format("ebay/listing_profiles/{0}.json", profileID))
        {
        }

        public GetListingProfileRequest(int profileID)
            : base(string.Format("ebay/listing_profiles/{0}.json", profileID))
        {
        }
    }
}
