using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAmazonProductRequest : HighwireGetRequest<GetAmazonProductRequest>
    {
        public GetAmazonProductRequest(int storeID, int amazonProductId)
            : base(storeID, string.Format("amazon/product/{0}.json", amazonProductId))
        {
        }

        public GetAmazonProductRequest(int amazonProductId)
            : base(string.Format("amazon/product/{0}.json", amazonProductId))
        {
        }
    }
}
