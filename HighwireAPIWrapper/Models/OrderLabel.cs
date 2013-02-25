using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class OrderLabel
    {
        public int? ID { get; set; }
        public string Private_Name { get; set; }
        public string Public_Name { get; set; }
        public bool? Email_Buyer { get; set; }
        public string Color { get; set; }
    }
}
