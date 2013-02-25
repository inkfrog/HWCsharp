using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetOrderRequest : HighwireGetRequest<GetOrderRequest>
    {
        public GetOrderRequest(int storeID, int orderID)
            : base(storeID, string.Format("orders/{0}.json", orderID))
        {
        }
    }
}
