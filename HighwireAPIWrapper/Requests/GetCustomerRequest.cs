using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetCustomerRequest : HighwireGetRequest<GetCustomerRequest>
    {
        public GetCustomerRequest(int storeID, int customerID)
            : base(storeID, string.Format("customer/{0}.json", customerID))
        {
        }
    }
}
