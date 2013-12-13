using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class EditReturnProfileRequest : HighwirePostOrPutRequest<ReturnProfile>
    {
        public EditReturnProfileRequest(int storeID, ReturnProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/return_profiles.json")
        {
        }

        public EditReturnProfileRequest(ReturnProfile profileData)
            : base(profileData, eHttpMethod.Post, "ebay/return_profiles.json")
        {
        }
    }
}
