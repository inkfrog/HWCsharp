using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateAmazonProductRequest : HighwirePostOrPutRequest<AmazonProduct>
    {
        public CreateAmazonProductRequest(int storeID, AmazonProduct productData)
            : base(storeID, productData, eHttpMethod.Post, "amazon/products.json")
        {
        }

        public CreateAmazonProductRequest(AmazonProduct productData)
            : base(productData, eHttpMethod.Post, "amazon/products.json")
        {
        }
    }
}
