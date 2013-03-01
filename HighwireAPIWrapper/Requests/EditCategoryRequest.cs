using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditCategoryRequest : HighwirePostOrPutRequest<Category>
    {
        public EditCategoryRequest(int storeID, Category categoryData)
            : base(storeID, categoryData, eHttpMethod.Put, string.Format("categories/{0}.json", categoryData.ID.Value))
        {
        }

        public EditCategoryRequest(Category categoryData)
            : base(categoryData, eHttpMethod.Put, string.Format("categories/{0}.json", categoryData.ID.Value))
        {
        }
    }
}
