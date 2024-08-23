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

        public static async Task CancelTask(string taskID)
        {
            string responseStr = await Https.GET($"/mission/cancel?TaskName={taskID}");
            Console.WriteLine($"Resonpse Of CancelTask ={responseStr}");
        }
    }
}
