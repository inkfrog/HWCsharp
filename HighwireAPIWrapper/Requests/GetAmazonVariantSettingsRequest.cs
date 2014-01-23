using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAmazonVariantSettingsRequest : HighwireGetRequest<GetAmazonVariantSettingsRequest>
    {
        public GetAmazonVariantSettingsRequest(int storeID, int productID, int variantID)
            : base(storeID, string.Format("products/{0}/{1}/amazon_variant_settings.json", productID, variantID))
        {
        }

                public GetAmazonVariantSettingsRequest(int productID, int variantID)
            : base(string.Format("products/{0}/{1}/amazon_variant_settings.json", productID, variantID))
        {
        }
    }
}
