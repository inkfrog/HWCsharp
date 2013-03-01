using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllOrderLabelsRequest : HighwireGetRequest<GetAllOrderLabelsRequest>
    {
        public GetAllOrderLabelsRequest(int storeID)
            : base(storeID, "orders/labels.json")
        {
        }

        public GetAllOrderLabelsRequest()
            : base("orders/labels.json")
        {
        }
    }
}
