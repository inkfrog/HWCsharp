using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteAmazonOfferRequest : HighwireRequest
    {
        public DeleteAmazonOfferRequest(int storeID, int offerID)
            : base(storeID, eHttpMethod.Delete, string.Format("amazon/offers/{0}.json", offerID))
        {
        }

        public DeleteAmazonOfferRequest(int offerID)
            : base(eHttpMethod.Delete, string.Format("amazon/offers/{0}.json", offerID))
        {
        }
    }
}
