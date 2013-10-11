using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class AddOrderItemToOrderRequest: HighwirePostOrPutRequest<OrderItem>
    {
        public AddOrderItemToOrderRequest(int storeID, int orderID, OrderItem itemData)
            : base(storeID, itemData, eHttpMethod.Post, string.Format("orders/{0}/items.json", orderID))
        {
        }

        public AddOrderItemToOrderRequest(int orderID, OrderItem itemData)
            : base(itemData, eHttpMethod.Post, string.Format("orders/{0}/items.json", orderID))
        {
        }
    }
}
