using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotUber
{
    public class Uber
    {
        public string ServerToken { get; set; }
        public string ClientId { get; set; }
        public string DefaultContentType {  get; private set; }
        public string AcceptLanguage { get; private set; }
        public static readonly HttpClient HttpClient = new HttpClient();

        public Uber()
        {
            this.AcceptLanguage = "en_EN";
            this.DefaultContentType = "application/json";
        }

        public Uber(string serverToken)
        {
            this.ServerToken = string.Format("Token {0}", serverToken);
            this.AcceptLanguage = "en_EN";
            this.DefaultContentType = "application/json";
        }

        public Uber(string serverToken, string clientId)
        {
            this.ServerToken = string.Format("Token {0}", serverToken);
            this.ClientId = clientId;
            this.AcceptLanguage = "en_EN";
            this.DefaultContentType = "application/json";
        }
    }
}
