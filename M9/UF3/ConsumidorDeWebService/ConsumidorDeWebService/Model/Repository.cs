
using ConsumidorDeWebService.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WSerCons0.Model
{
    public class Repository
    {
        string ws1 = "https://localhost:7146/api/";
        public List<Artist> GetArtists()
        {
            List<Artist> lc = null;
            lc = (List<Artist>)MakeRequest(string.Concat(ws1, "Artists"), null, "GET", "application/json", typeof(List<Artist>));
            return lc;
        }

        public List<Artist> GetArtists(String nom)
        {
            List<Artist> lc = null;
            lc = (List<Artist>)MakeRequest(string.Concat(ws1, "Artists/"+nom), null, "GET", "application/json", typeof(List<Artist>));
            return lc;
        }


        public Artist InsArtist(Artist art)
        {
            Artist a = (Artist)MakeRequest(string.Concat(ws1, "Artists"), art, "POST", "application/json", typeof(Artist));
            return a;
        }

        public Artist UpdArtist(Artist art, int id)
        {
            Artist a = (Artist)MakeRequest(string.Concat(ws1, "Artists/"+id), art, "PUT", "application/json", typeof(Artist));
            return a;
        }

        public Artist DelArtist(int id)
        {
            Artist a = (Artist)MakeRequest(string.Concat(ws1, "Artists/"+id), null, "DELETE", "application/json", typeof(Artist));
            return a;
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