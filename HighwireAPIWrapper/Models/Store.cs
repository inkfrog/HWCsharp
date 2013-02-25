using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class Store
    {
        public int? ID { get; set; }
        public DateTime? Created_At { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
        public string Email { get; set; }
        public string Currency { get; set; }
        public string Timezone { get; set; }
        public Address Address { get; set; }
        public string Plan_Name { get; set; }
    }
}
