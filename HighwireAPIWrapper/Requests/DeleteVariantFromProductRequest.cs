using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteVariantFromProductRequest : HighwireRequest
    {
        public DeleteVariantFromProductRequest(int storeID, int productID, int variantID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/variant/{1}.json", productID, variantID))
        {
        }

        public DeleteVariantFromProductRequest(int productID, int variantID)
            : base(eHttpMethod.Delete, string.Format("products/{0}/variant/{1}.json", productID, variantID))
        {
        }
    }
}
