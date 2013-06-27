using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllAmazonProductsRequest : HighwireGetRequest<GetAllAmazonProductsRequest>
    {
        public GetAllAmazonProductsRequest(int storeID)
            : base(storeID, "amazon/products.json")
        {
        }

        public GetAllAmazonProductsRequest()
            : base("amazon/products.json")
        {
        }
    }
}
