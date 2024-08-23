using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Vehicle
{
    public static class AGVAPI
    {
        public static async Task ONLINE(string agvID)
        {
            await Https.GET($"/agv/online?AGVID={agvID}&Command=ONLINE");

            //agv/online?AGVID=1&Command=ONLINE
        }
        public static async Task OFFLINE(string agvID)
        {
            await Https.GET($"/agv/online?AGVID={agvID}&Command=OFFLINE");

            //agv/online?AGVID=1&Command=ONLINE
        }
    }
}
