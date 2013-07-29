using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using NLog;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet
{
    public class JsonService : IJsonService
    {
        private string _url;
        protected CookieContainer Cookies;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public JsonService()
        {
            _url = "https://tripletex.no/JSON-RPC";
            Cookies = new CookieContainer();
        }

        public void ChangeUrl(string url)
        {
            _url = url;
        }

        private JToken SendAndParseWebRequest(object parameters)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(_url);
            webRequest.Method = "POST";
            webRequest.ContentType = "Content-Type: application/json";
            webRequest.CookieContainer = Cookies;

            var writer = new StreamWriter(webRequest.GetRequestStream());
            writer.Write(JsonConvert.SerializeObject(parameters));
            writer.Close();

            var response = webRequest.GetResponse();
            var stream = response.GetResponseStream();
            if (stream == null) return 0;

            var reader = new JsonTextReader(new StreamReader(stream));
            return JToken.ReadFrom(reader);
        }

        private static void HandleError(JToken token)
        {
            Logger.Error(token["error"]["msg"]);
            throw new Exception(token["error"]["msg"].ToString());
        }

        public T Call<T>(string method, params object[] params_) where T : class
        {
            var parameters = new
            {
                id = 1,
                method,
                @params = params_
            };

            var parsedData = SendAndParseWebRequest(parameters);

            if (parsedData["error"] != null)
            {
                HandleError(parsedData);
                return null;
            }

            return parsedData["result"].ToObject<T>();
        }

        public int Call(string method, params object[] params_)
        {
            var parameters = new
            {
                id = 1,
                method,
                @params = params_
            };

            var parsedData = SendAndParseWebRequest(parameters);

            if (parsedData["error"] != null)
            {
                HandleError(parsedData);
                return 0;
            }

            return Convert.ToInt32(parsedData["result"]);
        }
    }
}
