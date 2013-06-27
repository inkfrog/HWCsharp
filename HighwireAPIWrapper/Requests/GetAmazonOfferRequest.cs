using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAmazonOfferRequest : HighwireGetRequest<GetAmazonOfferRequest>
    {
        public GetAmazonOfferRequest(int storeID, int offerID)
            : base(storeID, string.Format("amazon/offer/{0}.json", offerID))
        {
        }

        public GetAmazonOfferRequest(int offerID)
            : base(string.Format("amazon/offer/{0}.json", offerID))
        {
        }
    }
}
