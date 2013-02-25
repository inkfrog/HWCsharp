using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class CustomerCollection
    {
        public int? Total_Entries { get; set; }
        public int? Limit { get; set; }
        public int? Current_Page { get; set; }
        public Customer[] Customer { get; set; }
    }
}
