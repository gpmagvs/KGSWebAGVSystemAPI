using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Sys
{
    public static class AlarmAPI
    {
        public static async Task ResetAlarm()
        {
            await Https.GET("/alarm/reset", 10);
        }
        public static async Task BuzzerOff()
        {
            await Https.GET("/alarm/buzzeroff");
        }
    }
}
