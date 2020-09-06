// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Store
{
    using Fluxor;

    public static class WeatherReducers
    {
        [ReducerMethod]
        public static WeatherState ReduceGetWeatherForecastsAction(WeatherState state, GetWeatherForecastsAction action)
             => state with { IsLoading = true };

        [ReducerMethod]
        public static WeatherState ReduceGetWeatherForecastsResultAction(WeatherState state, GetWeatherForecastsResultAction action)
             => state with { IsLoading = false, Forecasts = action.Forecasts };
    }
}
