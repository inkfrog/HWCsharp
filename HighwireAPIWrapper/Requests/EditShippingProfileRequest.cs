using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class EditShippingProfileRequest : HighwirePostOrPutRequest<ShippingProfile>
    {
        public EditShippingProfileRequest(int storeID, ShippingProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/shipping_profiles.json")
        {
        }

        public EditShippingProfileRequest(ShippingProfile profileData)
            : base(profileData, eHttpMethod.Post, "ebay/shipping_profiles.json")
        {
        }
    }
}
