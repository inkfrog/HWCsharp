using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllCustomersRequest : HighwireGetRequest<GetAllCustomersRequest>
    {
        /// <summary>
        /// Searches customer records by registered email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Searches customer records by registered last name.
        /// </summary>
        public string LastName { get; set; }

        public GetAllCustomersRequest(int storeID)
            : base(storeID, "customers.json")
        {
        }
    }
}
