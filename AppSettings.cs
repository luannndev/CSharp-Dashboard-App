
using System.IO;
using Newtonsoft.Json;

namespace AdvancedDesktopApp
{
    public static class AppSettings
    {
        public static string ApiKey { get; set; }
        public static string ApiUrl { get; set; }

        public static void LoadSettings()
        {
            var config = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("config/AppSettings.json"));
            ApiKey = config.ApiKey;
            ApiUrl = config.ApiUrl;
        }
    }
}
