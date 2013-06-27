using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteAmazonProductRequest : HighwireRequest
    {
        public DeleteAmazonProductRequest(int storeID, int amazonProductID)
            : base(storeID, eHttpMethod.Delete, string.Format("amazon/products/{0}.json", amazonProductID))
        {
        }

        public DeleteAmazonProductRequest(int amazonProductID)
            : base(eHttpMethod.Delete, string.Format("amazon/products/{0}.json", amazonProductID))
        {
        }
    }
}
