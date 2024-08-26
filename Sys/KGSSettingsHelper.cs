using Nini.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Sys
{
    public static class KGSSettingsHelper
    {
        /// <summary>
        /// 取得當前地圖json路徑
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentMapUseFilePath()
        {
            string iniFolder = Path.GetDirectoryName(Globals.KGSLogicIniPath);
            string mapName = LogicContent()["MapInfo"].Get("CurrentMap");
            return Path.Combine(iniFolder, $"{mapName}.json");
        }



        public static ConfigCollection LogicContent()
        {
            string[] lines = File.ReadAllLines(Globals.KGSLogicIniPath);
            List<string> filteredLines = lines.Where(line => !line.Contains("//")).Distinct().ToList();
            string tempPath = Path.GetTempFileName();
            File.WriteAllLines(tempPath, filteredLines);
            IniConfigSource configSource = new IniConfigSource(tempPath);
            return configSource.Configs;
        }

    }
}
