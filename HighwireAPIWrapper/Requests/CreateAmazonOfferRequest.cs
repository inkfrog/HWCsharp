using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateAmazonOfferRequest : HighwirePostOrPutRequest<AmazonOffer>
    {
        public CreateAmazonOfferRequest(int storeID, AmazonOffer offerData)
            : base(storeID, offerData, eHttpMethod.Post, "amazon/offers.json")
        {
        }

        public CreateAmazonOfferRequest(AmazonOffer offerData)
            : base(offerData, eHttpMethod.Post, "amazon/offers.json")
        {
        }
    }
}
