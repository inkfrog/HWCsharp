using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllCategoriesRequest : HighwireGetRequest<GetAllCategoriesRequest>
    {
        public int ParentID { get; set; }

        public GetAllCategoriesRequest(int storeID)
            : base(storeID, "categories.json")
        {
        }
    }
}
