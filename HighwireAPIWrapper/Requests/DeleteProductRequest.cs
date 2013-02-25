using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteProductRequest : HighwireRequest
    {
        public DeleteProductRequest(int storeID, int productID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}.json", productID))
        {
        }
    }
}
