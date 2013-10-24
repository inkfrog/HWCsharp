using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class EditListingProfileRequest : HighwirePostOrPutRequest<ListingProfile>
    {
        public EditListingProfileRequest(int storeID, ListingProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/listing_profiles.json")
        {
        }

        public EditListingProfileRequest(ListingProfile profileData)
            : base(profileData, eHttpMethod.Post, "ebay/listing_profiles.json")
        {
        }
    }
}
