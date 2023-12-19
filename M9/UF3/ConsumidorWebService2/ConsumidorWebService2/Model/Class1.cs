using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorWebService2.Model
{

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string price_sign { get; set; }
        public string currency { get; set; }
        public string image_link { get; set; }
        public string product_link { get; set; }
        public string website_link { get; set; }
        public string description { get; set; }
        public float? rating { get; set; }
        public string category { get; set; }
        public string product_type { get; set; }
        public string[] tag_list { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string product_api_url { get; set; }
        public string api_featured_image { get; set; }
        public Product_Colors[] product_colors { get; set; }
    }

    public class Product_Colors
    {
        public string hex_value { get; set; }
        public string colour_name { get; set; }
    }

}

