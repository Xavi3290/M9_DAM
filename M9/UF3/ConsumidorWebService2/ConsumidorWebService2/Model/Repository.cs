using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace ConsumidorWebService2.Model
{
    internal class Repository
    {
        string ws1 = "https://makeup-api.herokuapp.com/api/v1/products.json";
        // https://makeup-api.herokuapp.com/

        public List<maquillaje> GetMaquillajeBrandGente(String marca)
        {
            List<maquillaje> lc = null;
            lc = (List<maquillaje>)MakeRequest(string.Concat(ws1, "?brand="+marca), null, "GET", "application/json", typeof(List<maquillaje>));
            return lc;
        }

        public List<maquillaje> GetMaquillajeFiltrarNom(List<maquillaje> ma,String nom)
        {
            List<maquillaje> lc = null;
            lc = ma.Where(a => a.name.Contains(nom)).ToList();
            return lc;
        }

        public List<maquillaje> GetMaquillajeFiltrarNom2(String nom)
        {
            List<maquillaje> lc = null;
            lc = GetMaquillajes().Where(a => a.name.Contains(nom)).ToList();
            return lc;
        }

        public List<maquillaje> GetMaquillajes()
        {
            List<maquillaje> lc = null;
            lc = (List<maquillaje>)MakeRequest(string.Concat(ws1, ""), null, "GET", "application/json", typeof(List<maquillaje>));
            return lc;
        }
       
        public List<maquillaje> GetMaquillajesConMarcaYProducto(String marca, String producto)
        {
            List<maquillaje> lc = null;
            lc = (List<maquillaje>)MakeRequest(string.Concat(ws1, "?brand="+marca+"&product_type="+producto), null, "GET", "application/json", typeof(List<maquillaje>));
            return lc;
        }


        //public List<maquillaje> GetMaquillajesBrand()
        //{
        //    List<maquillaje> lc = null;
        //    lc = GetMaquillajes().Where(a=>a.brand!=null).OrderBy(a=>a.brand).Distinct().ToList();

        //    return lc;
        //}

        public List<String> GetMaquillajesBrand()
        {
            List<String> lc = null;
            lc = GetMaquillajes().Where(a => a.brand != null).OrderBy(a => a.brand).Select(a => a.brand).Distinct().ToList();

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
