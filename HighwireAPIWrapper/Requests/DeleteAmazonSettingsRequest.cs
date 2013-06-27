using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteAmazonSettingsRequest : HighwireRequest
    {
        public DeleteAmazonSettingsRequest(int storeID, int productID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/amazon_settings.json", productID))
        {
        }

        public DeleteAmazonSettingsRequest(int productID)
            : base(eHttpMethod.Delete, string.Format("products/{0}/amazon_settings.json", productID))
        {
        }
    }
}
