using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorDeWebService.Model
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        public Artist()
        {

        }
        public Artist(int ArtistId, string Name)
        {
            this.ArtistId = ArtistId;
            this.Name = Name;
        }

        public Artist(String Name)
        {
            this.Name=Name;
        }



    }

    
}
