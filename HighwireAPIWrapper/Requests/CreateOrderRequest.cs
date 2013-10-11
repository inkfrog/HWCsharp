using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateOrderRequest : HighwirePostOrPutRequest<Order>
    {
        public CreateOrderRequest(int storeID, Order orderData)
            : base(storeID, orderData, eHttpMethod.Post, "orders.json")
        {
        }

        public CreateOrderRequest(Order orderData)
            : base(orderData, eHttpMethod.Post, "orders.json")
        {
        }
    }
}
