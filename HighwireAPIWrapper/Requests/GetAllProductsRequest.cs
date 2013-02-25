using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllProductsRequest : HighwireGetRequest<GetAllProductsRequest>
    {
        /// <summary>
        /// Default 1
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Number of products returned (max 100). Default 100
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Filters by starting letter of product title 
        /// </summary>
        public char StartsWith { get; set; }

        /// <summary>
        /// Column sort handle. "id", "title", "price", "inventory", "sku", "active" or "featured". Default id.
        /// </summary>
        public string SortBy { get; set; }

        /// <summary>
        /// Sorting preference. "asc" or "desc". Default desc.
        /// </summary>
        public string Order { get; set; }
        
        /// <summary>
        /// Filter all products with out of stock variants. 
        /// </summary>
        public bool OutOfStock { get; set; }
        
        /// <summary>
        /// Filter all products within a specified category id. Default 0
        /// </summary>
        public int Cat { get; set; }

        public GetAllProductsRequest(int storeID)
            : base(storeID, "products.json")
        {
            this.Page = 1;
            this.Limit = 100;
            this.SortBy = "id";
            this.Order = "desc";
            this.Cat = 0;
        }
    }
}
