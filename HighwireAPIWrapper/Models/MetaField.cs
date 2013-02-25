using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class MetaField
    {
        public string Namespace { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int? ID { get; set; }
    }
}
