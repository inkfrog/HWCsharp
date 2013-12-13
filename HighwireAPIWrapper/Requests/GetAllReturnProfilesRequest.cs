using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllReturnProfilesRequest : HighwireGetRequest<GetAllReturnProfilesRequest>
    {
        public GetAllReturnProfilesRequest(int storeID)
            : base(storeID, "ebay/return_profiles.json")
        {
        }

        public GetAllReturnProfilesRequest()
            : base("ebay/return_profiles.json")
        {
        }
    }
}
