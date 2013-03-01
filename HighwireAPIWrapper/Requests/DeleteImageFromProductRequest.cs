using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteImageFromProductRequest : HighwireRequest
    {
        public DeleteImageFromProductRequest(int storeID, int productID, int imageID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/images/{1}.json", productID, imageID))
        {
        }

        public DeleteImageFromProductRequest(int productID, int imageID)
            : base(eHttpMethod.Delete, string.Format("products/{0}/images/{1}.json", productID, imageID))
        {
        }
    }
}
