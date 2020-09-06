// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Services
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using BlazorApp.Weather.Models;

    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            // delay to simulate the network
            await Task.Delay(300);
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
