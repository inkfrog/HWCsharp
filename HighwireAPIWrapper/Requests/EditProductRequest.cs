using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditProductRequest : HighwirePostOrPutRequest<Product>
    {
        public EditProductRequest(int storeID, Product productData)
            : base(storeID, productData, eHttpMethod.Put, string.Format("products/{0}.json", productData.ID.Value))
        {
        }

        public EditProductRequest(Product productData)
            : base(productData, eHttpMethod.Put, string.Format("products/{0}.json", productData.ID.Value))
        {
        }
    }
}
