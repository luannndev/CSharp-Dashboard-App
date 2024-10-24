
using System.Net.Http;

namespace AdvancedDesktopApp
{
    public static class WeatherAPI
    {
        public static string GetWeather()
        {
            using (HttpClient client = new HttpClient())
            {
                AppSettings.LoadSettings();
                string apiUrl = $"{AppSettings.ApiUrl}?key={AppSettings.ApiKey}";
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
