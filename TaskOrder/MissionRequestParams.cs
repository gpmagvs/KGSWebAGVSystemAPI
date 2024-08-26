using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.TaskOrder
{
    public class MissionRequestParams
    {
        public string CarName { get; set; } = "";
        public int AGVID { get; set; }
        public string Action { get; set; } = "";
        public string FromStation { get; set; }
        public int FromSlot { get; set; }
        public string ToStation { get; set; }
        public int ToSlot { get; set; }
        public int Priority { get; set; }
        public int RepeatTime { get; set; } = 1;
        public string CSTID { get; set; } = "";
        public int CSTType { get; set; }

        public override string ToString()
        {
            return $"CarName={CarName}&CSTType={CSTType}&AGVID={AGVID}&Action={Action}&FromStation={FromStation}&FromSlot={FromSlot}&ToStation={ToStation}&ToSlot={ToSlot}&Priority={Priority}&RepeatTime={RepeatTime}&CSTID={CSTID}";
        }
    }
}
