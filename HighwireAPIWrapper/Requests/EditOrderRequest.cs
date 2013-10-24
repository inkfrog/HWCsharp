using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditOrderRequest : HighwirePostOrPutRequest<Order>
    {
        public EditOrderRequest(int storeID, Order orderData)
            : base(storeID, orderData, eHttpMethod.Put, string.Format("orders/{0}.json", orderData.ID.Value))
        {
        }

        public EditOrderRequest(Order orderData)
            : base(orderData, eHttpMethod.Put, string.Format("orders/{0}.json", orderData.ID.Value))
        {
        }
    }
}
