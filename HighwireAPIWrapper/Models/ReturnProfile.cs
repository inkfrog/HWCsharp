using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class ReturnProfile
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public bool? Default { get; set; }
        public bool? ReturnPolicy { get; set; }
        public string Return_Within { get; set; }
        public string Return_Refund_As { get; set; }
        public string Return_Actor { get; set; }
        public string Return_Details { get; set; }
        public string Restocking_Fee { get; set; }
        public bool? Product_Profile { get; set; }
        public long? BusinessProfileID { get; set; }
    }
}
