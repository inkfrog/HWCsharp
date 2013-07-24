using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAmazonSettingsRequest : HighwireGetRequest<GetAmazonSettingsRequest>
    {
        public GetAmazonSettingsRequest(int storeID, int productID)
            : base(storeID, string.Format("products/{0}/amazon_settings.json", productID))
        {
        }

        public GetAmazonSettingsRequest(int productID)
            : base(string.Format("products/{0}/amazon_settings.json", productID))
        {
        }
    }
}
