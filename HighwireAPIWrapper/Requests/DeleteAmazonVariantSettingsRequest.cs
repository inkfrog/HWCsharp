using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteAmazonVariantSettingsRequest : HighwireRequest
    {
        public DeleteAmazonVariantSettingsRequest(int storeID, int productID, int variantID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/{1}/amazon_variant_settings.json", productID, variantID))
        {
        }

        public DeleteAmazonVariantSettingsRequest(int productID, int variantID)
            : base(eHttpMethod.Delete, string.Format("products/{0}/{1}/amazon_variant_settings.json", productID, variantID))
        {
        }
    }
}
