// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Store
{
    using System.Threading.Tasks;
    using BlazorApp.Weather.Services;
    using Fluxor;

    public class GetWeatherForecastsActionEffect
    {
        private readonly IWeatherService _weatherService;

        public GetWeatherForecastsActionEffect(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [EffectMethod]
        public async Task HandleGetWeatherForecastsAction(GetWeatherForecastsAction action, IDispatcher dispatcher)
        {
            var forecasts = await _weatherService.GetWeatherForecasts();
            dispatcher.Dispatch(new GetWeatherForecastsResultAction(forecasts));
        }
    }
}
