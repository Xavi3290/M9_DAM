using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorWebService2.Model
{
    public class maquillaje
    {
        public String name { get; set; }       
        
        public String brand { get; set; }

        public String image_link { get; set; }

        public String product_type { get; set; }

        public String price { get; set; }

       // public List<String> tag_list { get; set; }
        //public string[] tag_list { get; set; }

        public List<ProductColors> product_colors { get; set; }

        public maquillaje(string name, string brand, string image_link, string product_type, string price, List<ProductColors> product_colors)
        {
            this.name = name;
            this.brand = brand;
            this.image_link = image_link;
            this.product_type = product_type;
            this.price = price;
            this.product_colors = product_colors;
        }

        public maquillaje()
        {
        }
    }
}
