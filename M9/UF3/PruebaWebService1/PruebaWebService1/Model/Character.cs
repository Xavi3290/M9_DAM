using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWebService1.Model
{
    public class Character
    {
        public String name { get; set; }

        public String gender { get; set; }

        public String culture { get; set; }

        public List<String> titles { get; set; }

        public List<String> aliases { get; set; }

        public List<String> tvSeries { get; set; }

        public List<String> playedBy { get; set; }

        public Character()
        {
        }

        public Character(string name, string gender, string culture, List<string> titles, List<string> aliases, List<string> tvSeries, List<string> playedBy)
        {
            this.name = name;
            this.gender = gender;
            this.culture = culture;
            this.titles = titles;
            this.aliases = aliases;
            this.tvSeries = tvSeries;
            this.playedBy = playedBy;
        }
    }
}
