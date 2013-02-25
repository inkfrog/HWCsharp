using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetProductRequest : HighwireGetRequest<GetProductRequest>
    {
        public GetProductRequest(int storeID, int productID)
            : base(storeID, string.Format("products/{0}.json", productID))
        {
        }
    }
}
