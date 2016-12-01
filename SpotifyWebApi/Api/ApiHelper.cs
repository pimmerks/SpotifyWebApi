using Newtonsoft.Json;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Api
{
    public static class ApiHelper
    {
        public static string GetJsonFromUrl(string url, Token token)
        {
            return GetJsonFromUrl(new Uri(url), token);
        }

        public static string GetJsonFromUrl(Uri url, Token token)
        {
            string json = "";

            WebRequest request = WebRequest.Create(url);

            var headers = new NameValueCollection();
            headers["Authorization"] = token.Type + " " + token.AccessToken;
            request.ContentType = "application/x-www-form-urlencoded";
            //headers["Content-Type"] = "application/x-www-form-urlencoded";


            request.Headers = new WebHeaderCollection();
            request.Headers.Add(headers);

            WebResponse response;
            try
            {
                response = request.GetResponse();
            }
            catch (Exception)
            {
                return null;
            }

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            json += reader.ReadToEnd();

            return json;
        }

        public static T JsonToObject<T>(string json)
        {
            if (json != null)
                return JsonConvert.DeserializeObject<T>(json);

            return default(T);
        }

        public static T GetObjectFromUrl<T>(string url, Token token)
        {
            return JsonToObject<T>(GetJsonFromUrl(url, token));
        }
    }
}
