using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Sys
{
    public static class ModesAPI
    {
        public static async Task OPModeSwitch(OP_MODE mode)
        {
            await Https.GET($"/host/auto?Auto={(int)mode}");
        }
    }

    public enum OP_MODE
    {
        OP = 1,
        AUTO = 2
    }
}
