using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class AddImageToProductRequest : HighwirePostOrPutRequest<Image>
    {
        public AddImageToProductRequest(int storeID, int productID, Image imageData)
            : base(storeID, imageData, eHttpMethod.Post, string.Format("products/{0}/images.json", productID))
        {
        }

    }
}
