using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateEbaySettingsRequest : HighwirePostOrPutRequest<EbaySettings>
    {
        public CreateEbaySettingsRequest(int storeID, int productID, EbaySettings settingsData)
            : base(storeID, settingsData, eHttpMethod.Put, string.Format("products/{0}/ebay_settings.json", productID))
        {
        }

        public CreateEbaySettingsRequest(int productID, EbaySettings settingsData)
            : base(settingsData, eHttpMethod.Put, string.Format("products/{0}/ebay_settings.json", productID))
        {
        }
    }
}
