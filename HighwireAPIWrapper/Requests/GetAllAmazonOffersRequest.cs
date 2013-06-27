using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllAmazonOffersRequest : HighwireGetRequest<GetAllAmazonOffersRequest>
    {
        public GetAllAmazonOffersRequest(int storeID)
            : base(storeID, "amazon/offers.json")
        {
        }

        public GetAllAmazonOffersRequest()
            : base("amazon/offers.json")
        {
        }
    }
}
