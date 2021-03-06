﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class EditOrderLabelRequest : HighwirePostOrPutRequest<OrderLabel>
    {
        public EditOrderLabelRequest(int storeID, OrderLabel labelData)
            : base(storeID, labelData, eHttpMethod.Put, string.Format("orders/labels/{0}.json", labelData.ID.Value))
        {
        }

        public EditOrderLabelRequest(OrderLabel labelData)
            : base(labelData, eHttpMethod.Put, string.Format("orders/labels/{0}.json", labelData.ID.Value))
        {
        }
    }
}
