using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllOrdersRequest : HighwireGetRequest<GetAllOrdersRequest>
    {
        /// <summary>
        /// Default 1.
        /// </summary>
        public int Page { get; set; }
        
        /// <summary>
        /// Number of products returned. Max 100. Default 100.
        /// </summary>
        public int Limit { get; set; }
        
        /// <summary>
        /// Column sort handle. "id", "total", "created_at", "updated_at", "label_id", or "last_name". Default id.
        /// </summary>
        public string SortBy { get; set; }
        
        /// <summary>
        /// Sorting preference. "asc" or "desc". Default desc.
        /// </summary>
        public string Order { get; set; }
        
        /// <summary>
        /// Current status of order. "open", "closed", or "any". Default any.
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// Retrieve orders created after UTC date/time (format: 2012-01-01T06:00:00) 	
        /// </summary>
        public DateTime? Created_At_Min { get; set; }
        
        /// <summary>
        /// Retrieve orders created before UTC date/time (format: 2012-01-01T06:00:00) 	
        /// </summary>
        public DateTime? Created_At_Max { get; set; }
        
        /// <summary>
        /// Retrieve orders updated after UTC date/time (format: 2012-01-01T06:00:00)
        /// </summary>
        public DateTime? Updated_At_Min { get; set; }
        
        /// <summary>
        /// Retrieve orders updated before UTC date/time (format: 2012-01-01T06:00:00) 
        /// </summary>
        public DateTime? Updated_At_Max { get; set; }
        
        /// <summary>
        /// Filters orders based on payment status.
        /// </summary>
        public bool? Payment_Received { get; set; }
        
        /// <summary>
        /// Filters orders based on shipped status.
        /// </summary>
        public bool? Order_Shipped { get; set; }
        
        /// <summary>
        /// Filters orders submitted by customer record 
        /// </summary>
        public int? Customer_ID { get; set; }
        
        /// <summary>
        /// Searches orders by email 
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Searches orders by last name
        /// </summary>
        public string Last_Name { get; set; }

        public GetAllOrdersRequest(int storeID)
            : base(storeID, "orders.json")
        {
            this.Page = 1;
            this.Limit = 100;
            this.SortBy = "id";
            this.Order = "desc";
            this.Status = "any";
        }
    }
}
