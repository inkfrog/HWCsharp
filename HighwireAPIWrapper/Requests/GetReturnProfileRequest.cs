using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetReturnProfileRequest : HighwireGetRequest<GetReturnProfileRequest>
    {
        public GetReturnProfileRequest(int storeID, int profileID)
            : base(storeID, string.Format("ebay/return_profiles/{0}.json", profileID))
        {
        }

        public GetReturnProfileRequest(int profileID)
            : base(string.Format("ebay/return_profiles/{0}.json", profileID))
        {
        }
    }
}
