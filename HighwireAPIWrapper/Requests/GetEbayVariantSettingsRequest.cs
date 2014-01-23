using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetEbayVariantSettingsRequest : HighwireGetRequest<GetEbayVariantSettingsRequest>
    {
        public GetEbayVariantSettingsRequest(int storeID, int productID, int variantID)
            : base(storeID, string.Format("products/{0}/{1}/ebay_variant_settings.json", productID, variantID))
        {
        }

        public GetEbayVariantSettingsRequest(int productID, int variantID)
            : base(string.Format("products/{0}/{1}/ebay_variant_settings.json", productID, variantID))
        {
        }
    }
}
