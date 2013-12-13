using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateReturnProfileRequest : HighwirePostOrPutRequest<ReturnProfile>
    {
        public CreateReturnProfileRequest(int storeID, ReturnProfile profileData)
            : base(storeID, profileData, eHttpMethod.Post, "ebay/return_profiles.json")
        {
        }

        public CreateReturnProfileRequest(ReturnProfile profileData)
            : base(profileData, eHttpMethod.Post, "ebay/return_profiles.json")
        {
        }
    }
}
