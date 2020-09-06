// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Store
{
    using System;
    using System.Collections.Generic;
    using BlazorApp.Weather.Models;

    public record WeatherState
    {
        public WeatherState(bool isLoading)
        {
            IsLoading = isLoading;
        }

        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts;
        }

        public bool IsLoading { get; set; }
        public IEnumerable<WeatherForecast> Forecasts { get; set; }
    }
}
