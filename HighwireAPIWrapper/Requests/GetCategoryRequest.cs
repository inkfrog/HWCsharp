using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{ 
    public class GetCategoryRequest : HighwireGetRequest<GetCategoryRequest>
    {
        public GetCategoryRequest(int storeID, int categoryID)
            : base(storeID, string.Format("categories/{0}.json", categoryID))
        {
        }
    }
}
