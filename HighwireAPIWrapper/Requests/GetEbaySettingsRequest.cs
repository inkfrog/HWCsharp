using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetEbaySettingsRequest : HighwireGetRequest<GetEbaySettingsRequest>
    {
        public GetEbaySettingsRequest(int storeID, int productID)
            : base(storeID, string.Format("products/{0}/ebay_settings.json", productID))
        {
        }
    }
}
