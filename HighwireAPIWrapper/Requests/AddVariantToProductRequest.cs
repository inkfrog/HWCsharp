using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class AddVariantToProductRequest : HighwirePostOrPutRequest<Variant>
    {
        public AddVariantToProductRequest(int storeID, int productID, Variant variantData)
            : base(storeID, variantData, eHttpMethod.Post, string.Format("products/{0}/variants.json", productID))
        {
        }
    }
}
