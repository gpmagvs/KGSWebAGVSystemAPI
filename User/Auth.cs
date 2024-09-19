using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.User
{
    public class Auth
    {
        public static event EventHandler<(string userName, string password, string sid, string io)> OnUserLoginStart;
        public static event EventHandler<(string userName, string password, string sid, string io)> OnUserLoginSuccess;
        public static event EventHandler<(string userName, string password, string sid, string io)> OnUserLoginFailure;

        public static async Task<(bool success, string sid, string io)> LoginAndUpdateCookieStore(string userName, string password)
        {

            string sid = await GetwebsiteSID(CancellationToken.None);

            if (string.IsNullOrEmpty(sid))
            {
                OnUserLoginFailure?.Invoke("Get SID Process Fail", ("", "", "", ""));
                return (false, "", "");
            }

            string io = $"2BPc0hLL{DateTime.Now.ToString("yyMMddHHmmss")}";
            bool success = false;
            var baseAddress = new Uri(Globals.KGSWebAGVSystemAPI);
            var cookieContainer = new CookieContainer();
            cookieContainer.Add(baseAddress, new Cookie("connect.sid", sid));
            cookieContainer.Add(baseAddress, new Cookie("io", io));
            var responseString = "";

            try
            {
                using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
                using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Accept.ParseAdd("application/json, text/javascript, */*; q=0.01");
                    client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("gzip, deflate");
                    client.DefaultRequestHeaders.AcceptLanguage.ParseAdd("zh-TW,zh;q=0.9,en-US;q=0.8,en;q=0.7");
                    client.DefaultRequestHeaders.Referrer = new Uri($"{baseAddress.ToString()}/login");
                    client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
                    client.DefaultRequestHeaders.Add("Origin", baseAddress.ToString());

                    StringContent content = new StringContent($"[{{\"name\":\"UserName\",\"value\":\"{userName}\"}},{{\"name\":\"Password\",\"value\":\"{password}\"}}]", System.Text.Encoding.UTF8, "application/json");
                    OnUserLoginStart?.Invoke("Auth", (userName, password, sid, io));
                    var response = await client.PostAsync("/user/login", content);

                    Console.WriteLine($"StatusCode Of Login Request = {response.StatusCode}");
                    success = response.StatusCode == HttpStatusCode.OK;
                    responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseString);
                }

                if (success)
                {
                    Globals.cookieInfo.sid = sid;
                    Globals.cookieInfo.io = io;
                    OnUserLoginSuccess?.Invoke("Auth", (userName, password, sid, io));
                }
                else
                {
                    Globals.cookieInfo.sid = Globals.cookieInfo.io = null;
                    OnUserLoginFailure?.Invoke("Auth", (userName, password, sid, io));
                }

                return (success, sid, io);
            }
            catch (Exception ex)
            {
                OnUserLoginFailure?.Invoke("Auth", (userName, password, sid, io));
                throw ex;
            }
        }


        public static async Task<string> GetwebsiteSID(CancellationToken cancelToken)
        {
            try
            {
                string website_url = Globals.KGSWebAGVSystemAPI;
                Console.WriteLine($"Get Website SID From : {website_url}");
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(5);
                var response = await client.GetAsync(website_url, cancelToken);
                var cookieHeader = response.Headers.GetValues("Set-Cookie");
                string SID = cookieHeader.First().Split('=')[1].Split(';')[0];
                Console.WriteLine($"Get Website SID From : {website_url} => {SID}");
                return SID;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                return "";
            }
        }
    }
}
