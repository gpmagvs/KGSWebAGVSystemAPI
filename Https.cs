using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI
{
    public static class Https
    {
        public static async Task<string> GET(string apiRoute, int timeout = 3)
        {
            var responseString = "";
            var baseAddress = new Uri(Globals.KGSWebAGVSystemAPI);
            try
            {
                var cookieContainer = new CookieContainer();
                cookieContainer.Add(baseAddress, new Cookie("connect.sid", Globals.cookieInfo.sid));
                cookieContainer.Add(baseAddress, new Cookie("io", Globals.cookieInfo.io));

                using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
                using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
                {
                    client.Timeout = TimeSpan.FromSeconds(timeout);
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Accept.ParseAdd("*/*");
                    client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("gzip, deflate");
                    client.DefaultRequestHeaders.AcceptLanguage.ParseAdd("zh-TW,zh;q=0.9,en-US;q=0.8,en;q=0.7");

                    string[] segments = apiRoute.Split('/');
                    string targetSegment = segments.Length > 1 ? segments[1] : string.Empty;

                    client.DefaultRequestHeaders.Referrer = new Uri($"{baseAddress.ToString()}/${targetSegment}");
                    client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
                    HttpResponseMessage response = await client.GetAsync(apiRoute);
                    responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"GET Requst({apiRoute})\r\n *StatusCode={response.StatusCode}\r\n *Content= {responseString}");

                }
                return responseString;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GET Requst({baseAddress.ToString()}{apiRoute}) Error : {ex.Message}");
                throw ex;
            }
        }
    }
}
