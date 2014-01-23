using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class CreateEbayVariantSettingsRequest : HighwirePostOrPutRequest<EbayVariantSettings>
    {
        public CreateEbayVariantSettingsRequest(int storeID, int productID, int variantID, EbayVariantSettings settingsData)
            : base(storeID, settingsData, eHttpMethod.Put, string.Format("products/{0}/{1}/ebay_variant_settings.json", productID, variantID))
        {
        }

        public CreateEbayVariantSettingsRequest(int productID, int variantID, EbayVariantSettings settingsData)
            : base(settingsData, eHttpMethod.Put, string.Format("products/{0}/{1}/ebay_variant_settings.json", productID, variantID))
        {
        }
    }
}
