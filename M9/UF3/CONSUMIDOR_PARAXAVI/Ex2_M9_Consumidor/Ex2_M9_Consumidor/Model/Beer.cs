using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_M9_Consumidor.Model
{
    public class Beer
    {
        public int id { get; set; }
        public string name { get; set; }

        public string description { get; set; }
        public string ph { get; set; }
        public string tagline { get; set; }
        public string image_url { get; set; }

        public string first_brewed { get; set; }
        public string attenuation_level { get; set; }
        
        public Ingredients ingredients { get; set; }
        public string brewers_tips { get; set; }

        public string contributed_by { get; set; }
        
        public Volume volume { get; set; }

       public List<string> food_pairing { get; set; }


        public Beer(int id, string name, string description,string ph, string tagline, string image_url, string first_brewed, string attenuation_level, string brewers_tips, string contributed_by, Volume volume)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.ph = ph;
            this.tagline = tagline;
            this.image_url = image_url;
            this.first_brewed = first_brewed;
            this.attenuation_level = attenuation_level;
            this.brewers_tips = brewers_tips;
            this.contributed_by = contributed_by;
            this.volume = volume;
           
        }
        public Beer()
        {

        }
    }
}
