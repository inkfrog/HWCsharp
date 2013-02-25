using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteCategoryRequest : HighwireRequest
    {
        public DeleteCategoryRequest(int storeID, int categoryID)
            : base(storeID, eHttpMethod.Delete, string.Format("categories/{0}.json", categoryID))
        {
        }
    }
}
