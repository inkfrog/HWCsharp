using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateShippingProfileRequest : HighwirePostOrPutRequest<ShippingProfile>
    {
        public CreateShippingProfileRequest(int storeID, ShippingProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/shipping_profiles.json")
        {
        }
    }
}
