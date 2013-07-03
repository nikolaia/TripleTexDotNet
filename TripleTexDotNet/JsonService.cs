using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet
{
    public class JsonService : IJsonService
    {
        private string _url;
        protected CookieContainer Cookies;

        public JsonService()
        {
            _url = "https://tripletex.no/JSON-RPC";
            Cookies = new CookieContainer();
        }

        public void ChangeUrl(string url)
        {
            _url = url;
        }

        public T Call<T>(string method, params object[] params_) where T : class
        {
            var parameters = new
            {
                id = 1,
                method,
                @params = params_
            };

            var webRequest = (HttpWebRequest)WebRequest.Create(_url);
            webRequest.Method = "POST";
            webRequest.ContentType = "Content-Type: application/json";
            webRequest.CookieContainer = Cookies;

            var writer = new StreamWriter(webRequest.GetRequestStream());
            writer.Write(JsonConvert.SerializeObject(parameters));
            writer.Close();

            var response = webRequest.GetResponse();
            var stream = response.GetResponseStream();
            if (stream == null) return null;

            var reader = new JsonTextReader(new StreamReader(stream));
            var parsedData = JToken.ReadFrom(reader);

            return parsedData == null ? default(T) : parsedData["result"].ToObject<T>();
        }
    }
}
