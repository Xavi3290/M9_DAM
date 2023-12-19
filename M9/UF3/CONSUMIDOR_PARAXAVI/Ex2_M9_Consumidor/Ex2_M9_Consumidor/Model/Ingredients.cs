using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_M9_Consumidor.Model
{
    public class Ingredients
    {
        public List<Malt> malt { get; set; }

        public Ingredients(List<Malt> malt)
        {
            this.malt = malt;
        }

        public Ingredients()
        {
        }
        // public List<Hops> hops { get; set; }


    }
}
