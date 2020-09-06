// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Pages
{
    using System.Threading.Tasks;
    using BlazorApp.Weather.Store;
    using Fluxor;
    using Microsoft.AspNetCore.Components;

    public partial class Forecasts
    {
        [Inject]
        private IState<WeatherState> WeatherState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Dispatcher.Dispatch(new GetWeatherForecastsAction());
        }
    }
}
