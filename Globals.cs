using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI
{
    public static class Globals
    {
        public static string KGSHotIP { get; set; } = "192.168.0.3";
        public static int KGSHotPort { get; set; } = 5216;
        public static string KGSWebAGVSystemAPI => $"http://{KGSHotIP}:{KGSHotPort}";
        public static CookiesInfo cookieInfo { get; set; } = new CookiesInfo();
    }


    public class CookiesInfo
    {
        public string sid { get; set; }
        public string io { get; set; }
    }
}
