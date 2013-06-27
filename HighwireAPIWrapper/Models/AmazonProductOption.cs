using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class AmazonProductOption
    {
        public int ID { get; set; }
        public eAmazonProductOptionType OptionType { get; set; }
        public string OptionValue { get; set; }
    }
}
