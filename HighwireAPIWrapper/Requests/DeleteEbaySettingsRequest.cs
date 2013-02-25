using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteEbaySettingsRequest : HighwireRequest
    {
        public DeleteEbaySettingsRequest(int storeID, int productID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/ebay_settings.json", productID))
        {
        }
    }
}
