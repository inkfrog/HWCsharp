using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetOrderLabelRequest : HighwireGetRequest<GetOrderLabelRequest>
    {
        public GetOrderLabelRequest(int storeID, int labelID)
            : base(storeID, string.Format("orders/labels/{0}.json", labelID))
        {
        }

        public GetOrderLabelRequest(int labelID)
            : base(string.Format("orders/labels/{0}.json", labelID))
        {
        }
    }
}
