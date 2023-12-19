using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_M9_Consumidor.Model
{
    public class Volume
    {
        public string value { get; set; }
        public string unit { get; set; }

        public Volume(string value, string unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public Volume()
        {
        }
    }
}
