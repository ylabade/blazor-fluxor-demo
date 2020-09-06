// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Services
{
    using System.Threading.Tasks;
    using BlazorApp.Weather.Models;

    public interface IWeatherService
    {
        Task<WeatherForecast[]> GetWeatherForecasts();
    }
}
