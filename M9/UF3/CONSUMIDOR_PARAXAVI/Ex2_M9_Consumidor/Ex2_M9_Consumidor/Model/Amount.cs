using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_M9_Consumidor.Model
{
    public class Amount
    {
        public string value { get; set; }
        public string unit { get; set; }

        public Amount(string value, string unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public Amount()
        {
        }
    }
}
