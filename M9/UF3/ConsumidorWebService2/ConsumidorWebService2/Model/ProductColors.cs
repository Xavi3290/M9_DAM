using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorWebService2.Model
{
    public class ProductColors
    {
        public String hex_value { get; set; }
        public String colour_name { get; set; }

        public ProductColors()
        {
        }

        public ProductColors(string hex_value, string colour_name)
        {
            this.hex_value = hex_value;
            this.colour_name = colour_name;
        }
    }
}
