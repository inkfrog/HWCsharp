using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllListingProfilesRequest : HighwireGetRequest<GetAllListingProfilesRequest>
    {
        public GetAllListingProfilesRequest(int storeID)
            : base(storeID, "ebay/listing_profiles.json")
        {
        }

        public GetAllListingProfilesRequest()
            : base("ebay/listing_profiles.json")
        {
        }
    }
}
