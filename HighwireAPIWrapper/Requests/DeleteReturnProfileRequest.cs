using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteReturnProfileRequest : HighwireRequest
    {
        public DeleteReturnProfileRequest(int storeID, int profileID)
            : base(storeID, eHttpMethod.Delete, string.Format("ebay/return_profiles/{0}.json", profileID))
        {
        }

        public DeleteReturnProfileRequest(int profileID)
            : base(eHttpMethod.Delete, string.Format("ebay/return_profiles/{0}.json", profileID))
        {
        }
    }
}
