// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Store
{
    using System.Collections.Generic;
    using BlazorApp.Weather.Models;

    public class GetWeatherForecastsResultAction
    {
        public GetWeatherForecastsResultAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }

        public IEnumerable<WeatherForecast> Forecasts { get; }
    }
}
