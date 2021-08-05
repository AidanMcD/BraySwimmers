using System;
using Services.Interface;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;

using System.Web;


namespace Services.Models
{
    public class TideDataStrategy : IDataStrategy
    {
        public TideDataStrategy()
        {
        }

        public enum State { high, low }
        public DateTime Time { get; }


        public string GetData(Dictionary<string,string> parameters)
        {
            string endpoint = Environment.GetEnvironmentVariable("x-rapidapi-host"); 


            string prams = string.Join("&",parameters.Select(p => p.Key +"="+p.Value));
            Uri uri = new Uri(endpoint);
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                
            };




            return  "";
        }


    }
}