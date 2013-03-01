using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class UpdateOrderRequest : HighwirePostOrPutRequest<Order>
    {
        public UpdateOrderRequest(int storeID, Order orderData)
            : base(storeID, orderData, eHttpMethod.Put, string.Format("orders/{0}.json", orderData.ID.Value))
        {
        }

        public UpdateOrderRequest(Order orderData)
            : base(orderData, eHttpMethod.Put, string.Format("orders/{0}.json", orderData.ID.Value))
        {
        }
    }
}
