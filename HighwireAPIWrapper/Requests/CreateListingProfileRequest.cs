using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateListingProfileRequest : HighwirePostOrPutRequest<ListingProfile>
    {
        public CreateListingProfileRequest(int storeID, ListingProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/listing_profiles.json")
        {
        }
    }
}
