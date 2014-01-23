using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteEbayVariantSettingsRequest : HighwireRequest
    {
        public DeleteEbayVariantSettingsRequest(int storeID, int productID, int variantID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/{1}/ebay_variant_settings.json", productID, variantID))
        {
        }

        public DeleteEbayVariantSettingsRequest(int productID, int variantID)
            : base(eHttpMethod.Delete, string.Format("products/{0}/{1}/ebay_variant_settings.json", productID, variantID))
        {
        }
    }
}
