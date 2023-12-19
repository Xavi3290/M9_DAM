using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Ex2_M9_Consumidor.Model
{
    public class Repository
    {

        string ws1 = "https://api.punkapi.com/v2/";

        public List<Beer> GetBeers()
        {
           
            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?page=1&per_page=80"), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }
        public List<Beer> GetBeersPage2()
        {

            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?page=2&per_page=80"), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }
        public List<Beer> GetBeersPage3()
        {

            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?page=3&per_page=80"), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }
        public List<Beer> GetBeersPage4()
        {

            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?page=4&per_page=80"), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }
        public List<Beer> GetBeersPage5()
        {

            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?page=5&per_page=80"), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }
        public List<Beer> GetBeersName(string name)
        {
        
            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?beer_name=", name), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }
        public List<Beer> GetBeersFiltreFood(string name)
        {

            List<Beer> lc = null;
            lc = (List<Beer>)MakeRequest(string.Concat(ws1, "beers?food=", name), null, "GET", "application/json", typeof(List<Beer>));
            return lc;
        }

        public static object MakeRequest(string requestUrl, object JSONRequest, string JSONmethod, string JSONContentType, Type JSONResponseType)
        //  requestUrl: Url completa del Web Service, amb l'opció sol·licitada
        //  JSONrequest: objecte que se li passa en el body 
        //  JSONmethod: "GET"/"POST"/"PUT"/"DELETE"
        //  JSONContentType: "application/json" en els casos que el Web Service torni objectes
        //  JSONRensponseType:  tipus d'objecte que torna el Web Service (typeof(tipus))
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest; //WebRequest WR = WebRequest.Create(requestUrl);   
                string sb = JsonConvert.SerializeObject(JSONRequest);
                request.Method = JSONmethod;  // "GET"/"POST"/"PUT"/"DELETE";  

                if (JSONmethod != "GET")
                {
                    request.ContentType = JSONContentType; // "application/json";   
                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));

                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    string strsb = sr.ReadToEnd();
                    object objResponse = JsonConvert.DeserializeObject(strsb, JSONResponseType);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
