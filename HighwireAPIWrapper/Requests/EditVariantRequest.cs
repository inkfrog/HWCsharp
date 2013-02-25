using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditVariantRequest : HighwirePostOrPutRequest<Variant>
    {
        public EditVariantRequest(int storeID, int productID, Variant variantData)
            : base(storeID, variantData, eHttpMethod.Put, string.Format("products/{0}/variants/{1}.json", productID, variantData.ID.Value))
        {
        }
    }
}
