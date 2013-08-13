using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class CreateAmazonVariantSettingsRequest : HighwirePostOrPutRequest<AmazonVariantSettings>
    {
        public CreateAmazonVariantSettingsRequest(int storeID, int productID, int variantID, AmazonVariantSettings settingsData)
            : base(storeID, settingsData, eHttpMethod.Put, string.Format("products/{0}/{1}/amazon_variant_settings.json", productID, variantID))
        {
        }

        public CreateAmazonVariantSettingsRequest(int productID, int variantID, AmazonVariantSettings settingsData)
            : base(settingsData, eHttpMethod.Put, string.Format("products/{0}/{1}/amazon_variant_settings.json", productID, variantID))
        {
        }
    }
}
