using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeletePaymentProfileRequest : HighwireRequest
    {
        public DeletePaymentProfileRequest(int storeID, int profileID)
            : base(storeID, eHttpMethod.Delete, string.Format("ebay/payment_profiles/{0}.json", profileID))
        {
        }

        public DeletePaymentProfileRequest(int profileID)
            : base(eHttpMethod.Delete, string.Format("ebay/payment_profiles/{0}.json", profileID))
        {
        }
    }
}
