using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class UpdateOrderItemRequest: HighwirePostOrPutRequest<OrderItem>
    {
        public UpdateOrderItemRequest(int storeID, int orderItemID, OrderItem itemData)
            : base(storeID, itemData, eHttpMethod.Put, string.Format("orders/items/{0}.json", orderItemID))
        {
        }

        public UpdateOrderItemRequest(int orderItemID, OrderItem itemData)
            : base(itemData, eHttpMethod.Put, string.Format("orders/items/{0}.json", orderItemID))
        {
        }

    }
}
