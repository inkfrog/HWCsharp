using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteOrderLabelRequest : HighwireRequest
    {
        public DeleteOrderLabelRequest(int storeID, int labelID)
            : base(storeID, eHttpMethod.Delete, string.Format("orders/labels/{0}.json", labelID))
        {
        }

        public DeleteOrderLabelRequest(int labelID)
            : base(eHttpMethod.Delete, string.Format("orders/labels/{0}.json", labelID))
        {
        }
    }
}
