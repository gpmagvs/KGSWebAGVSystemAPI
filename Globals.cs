using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI
{
    public static class Globals
    {

        public static string KGSLogicIniPath { get; set; } = @"C:\CST\ini\Logic.ini";

        public static string KGSHotIP { get; set; } = "192.168.0.123";
        public static int KGSHotPort { get; set; } = 6600;
        public static string KGSWebAGVSystemAPI => $"http://{KGSHotIP}:{KGSHotPort}";
        public static CookiesInfo cookieInfo { get; set; } = new CookiesInfo();
    }


    public class CookiesInfo
    {
        public string sid { get; set; }
        public string io { get; set; }
    }
}
