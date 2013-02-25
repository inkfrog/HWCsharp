using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class CreateCategoryRequest : HighwirePostOrPutRequest<Category>
    {
        public CreateCategoryRequest(int storeID, Category categoryData)
            : base(storeID, categoryData, eHttpMethod.Post, "categories.json")
        {
        }
    }
}
