using KGSWebAGVSystemAPI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.TaskOrder
{
    public static class OrderAPI
    {
        public static async Task<string> AddTask(MissionRequestParams missionRequest)
        {
            string responseStr = await Https.GET($"/mission/request?{missionRequest.ToString()}");
            Console.WriteLine($"Resonpse Of AddTask ={responseStr}");
            return responseStr;
        }

        public static async ValueTask<string> CancelTask(string taskID)
        {

            if (Globals.cookieInfo.sid == null || Globals.cookieInfo.io == null)
            {
                await Auth.LoginAndUpdateCookieStore("gpm", "12345678");
            }

            string responseStr = await Https.GET($"/mission/cancel?TaskName={taskID}");
            Console.WriteLine($"Resonpse Of CancelTask ={responseStr}");
            return responseStr;
        }
    }
}
