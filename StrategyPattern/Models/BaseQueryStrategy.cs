using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StrategyPattern.Models
{
    public class BaseQueryStrategy : BaseStrategy
    {
        public string ReadDataFromUrl(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public string GetDataFromJSON<T>(string json) where T : IInformation
        {
            T source = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            return source.Value;
        }
    }
}
