using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace IPInfoReloaded
{
    public class MainViewModel
    {
        public string ZipCode { get; set; }
        public MainViewModel()
        {
            IPInfoPopulate();
        }
        public void IPInfoPopulate()
        {

            //create client
            var client = new HttpClient();
            // get
            var json = client.GetStringAsync("https://ipinfo.io/json").Result;
            var result = JsonConvert.DeserializeObject<IPInfoModel>(json);
            ZipCode = result.postal;
        }
    }
}
