using System.Net.WebSockets;

namespace ServerV4
{
    public class Usuari
    {
        public String nom { get; set; }

        public WebSocket ws { get; set; }

        public Usuari()
        {
        }

        public Usuari(string nom, WebSocket ws)
        {
            this.nom = nom;
            this.ws = ws;
        }
    }
}
