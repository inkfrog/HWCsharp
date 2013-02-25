using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteCategoryFromProductRequest : HighwireRequest
    {
        public DeleteCategoryFromProductRequest(int storeID, int productID, int categoryID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/categories/{1}.json", productID, categoryID))
        {
        }
    }
}
