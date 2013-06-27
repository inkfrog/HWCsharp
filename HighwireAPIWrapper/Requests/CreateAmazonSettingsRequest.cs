using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateAmazonSettingsRequest : HighwirePostOrPutRequest<AmazonSettings>
    {
        public CreateAmazonSettingsRequest(int storeID, int productID, AmazonSettings settingsData)
            : base(storeID, settingsData, eHttpMethod.Put, string.Format("products/{0}/amazon_settings.json", productID))
        {
        }

        public CreateAmazonSettingsRequest(int productID, AmazonSettings settingsData)
            : base(settingsData, eHttpMethod.Put, string.Format("products/{0}/amazon_settings.json", productID))
        {
        }
    }
}
