using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class AddCategoryToProductRequest : HighwirePostOrPutRequest<Category>
    {
        public AddCategoryToProductRequest(int storeID, int productID, int categoryID)
            : base(storeID, new Category() { ID = categoryID }, eHttpMethod.Post, string.Format("products/{0}/categories.json", productID))
        {
        }
    }
}
