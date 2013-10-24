using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditOrderItemRequest: HighwirePostOrPutRequest<OrderItem>
    {
        public EditOrderItemRequest(int storeID, int orderItemID, OrderItem itemData)
            : base(storeID, itemData, eHttpMethod.Put, string.Format("orders/items/{0}.json", orderItemID))
        {
        }

        public EditOrderItemRequest(int orderItemID, OrderItem itemData)
            : base(itemData, eHttpMethod.Put, string.Format("orders/items/{0}.json", orderItemID))
        {
        }

    }
}
