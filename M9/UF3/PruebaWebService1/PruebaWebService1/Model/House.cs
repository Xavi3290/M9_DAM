using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWebService1.Model
{
    public class House
    {
        public String name { get; set; }

        public String region { get; set; }

        public String words { get; set; }

        public List<String> titles { get; set; }

        public House()
        {
        }

        public House(string name, string region, string words, List<string> titles)
        {
            this.name = name;
            this.region = region;
            this.words = words;
            this.titles = titles;
        }
    }
}
