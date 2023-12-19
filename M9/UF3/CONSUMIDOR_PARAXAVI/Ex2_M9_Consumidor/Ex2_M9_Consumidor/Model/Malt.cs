using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_M9_Consumidor.Model
{
    public class Malt
    {
        public string name { get; set; }
        public Amount amount { get; set; }

        public Malt(string name, Amount amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public Malt()
        {
        }
    }
}
