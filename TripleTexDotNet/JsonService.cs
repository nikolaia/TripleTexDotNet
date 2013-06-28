﻿using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TripleTexDotNet
{
    public class JsonService
    {
        readonly string _url;
        protected CookieContainer Cookies;

        public JsonService(string url)
        {
            _url = url;
            Cookies = new CookieContainer();
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

            var reader = new JsonTextReader(new StreamReader(response.GetResponseStream()));

            var parsedData = JToken.ReadFrom(reader);

            return parsedData["result"] != null ? parsedData["result"].ToObject<T>() : null;
        }
    }
}