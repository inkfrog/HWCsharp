using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateOrderLabelRequest : HighwirePostOrPutRequest<OrderLabel>
    {
        public CreateOrderLabelRequest(int storeID, OrderLabel labelData)
            : base(storeID, labelData, eHttpMethod.Post, "orders/labels.json")
        {
        }

        public CreateOrderLabelRequest(OrderLabel labelData)
            : base(labelData, eHttpMethod.Post, "orders/labels.json")
        {
        }
    }
}
