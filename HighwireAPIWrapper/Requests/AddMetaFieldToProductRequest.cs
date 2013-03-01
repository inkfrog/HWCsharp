using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class AddMetaFieldToProductRequest : HighwirePostOrPutRequest<MetaField>
    {
        public AddMetaFieldToProductRequest(int storeID, int productID, MetaField fieldData)
            : base(storeID, fieldData, eHttpMethod.Post, string.Format("products/{0}/metafields.json", productID))
        {
        }

        public AddMetaFieldToProductRequest(int productID, MetaField fieldData)
            : base(fieldData, eHttpMethod.Post, string.Format("products/{0}/metafields.json", productID))
        {
        }
    }
}
