using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DotUber.Utils
{
    public static class RequestUtils
    {
        public static string GetBody(this HttpResponseMessage response)
        {
            string responseContents;
            using (Stream receiveStream = response.Content.ReadAsStreamAsync().Result)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    responseContents = readStream.ReadToEnd();
                }
            }
            return responseContents;
        }

        public static void ConfigureGetHttpRequestHeaders(ref HttpRequestMessage httpWebRequest, Uber uberProvider)
        {
            httpWebRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(uberProvider.DefaultContentType));
            httpWebRequest.Headers.Add("Accept-Language", uberProvider.AcceptLanguage);
            httpWebRequest.Headers.Add("Authorization", uberProvider.ServerToken);
        }
    }
}
