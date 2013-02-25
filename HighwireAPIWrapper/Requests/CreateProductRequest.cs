using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using Newtonsoft.Json;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class CreateProductRequest : HighwirePostOrPutRequest<Product>
    {
        public CreateProductRequest(int storeID, Product productData)
            : base(storeID, productData, eHttpMethod.Post, "products.json")
        {
        }
    }
}
