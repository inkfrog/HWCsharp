using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class Category
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public bool? Visible { get; set; }
        public int? Subcategory_Count { get; set; }
        public int? Position { get; set; }
        public int? Product_Count { get; set; }
        public string Description { get; set; }
        public string SEO_Title { get; set; }
        public string SEO_Description { get; set; }
        public string SEO_Keywords { get; set; }
        public string URLHandle { get; set; }
    }
}
