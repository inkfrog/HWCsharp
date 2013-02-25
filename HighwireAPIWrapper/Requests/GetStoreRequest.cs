using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetStoreRequest : HighwireGetRequest<GetStoreRequest>
    {
        public GetStoreRequest(int storeID) : base(storeID, "store.json")
        {
        }
    }
}
