using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsumidorV1.Model
{
    internal class Repository
    {
        string ws1 = "https://localhost:7123/api/";  // el numero de localhost cambia


        public List<Category> GetCategories()
        {
            List<Category> lc = null;
            lc = (List<Category>)MakeRequest(string.Concat(ws1, "Category"), null, "GET", "application/json", typeof(List<Category>));
            return lc;
        }

        public List<Category> GetCategories(String nom)
        {
            List<Category> lc = null;
            lc = (List<Category>)MakeRequest(string.Concat(ws1, "Category/" + nom), null, "GET", "application/json", typeof(List<Category>));
            return lc;
        }


        public Category InsCategories(Category cat)
        {
            Category c = (Category)MakeRequest(string.Concat(ws1, "Category"), cat, "POST", "application/json", typeof(Category));
            return c;
        }

        public Category UpdCategories(Category cat, int id)
        {
            Category a = (Category)MakeRequest(string.Concat(ws1, "Category/" + id), cat, "PUT", "application/json", typeof(Category));
            return a;
        }

        public Category DelCategories(int id)
        {
            Category a = (Category)MakeRequest(string.Concat(ws1, "Category/" + id), null, "DELETE", "application/json", typeof(Category));
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
