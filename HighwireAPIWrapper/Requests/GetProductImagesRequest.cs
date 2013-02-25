using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetProductImagesRequest : HighwireGetRequest<GetProductImagesRequest>
    {
        public GetProductImagesRequest(int storeID, int productID)
            : base(storeID, string.Format("products/{0}/images.json", productID))
        {
        }
    }
}
