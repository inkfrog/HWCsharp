using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class PartsCompatabilities
    {
        public int ID { get; set; }
        public string Notes { get; set; }
        public List<PartsCompatability> Compatabilities { get; set; }
        public int Ebay_GeneralProfile { get; set; }
    }
}
