// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Weather.Store
{
    using Fluxor;

    public class WeatherFeature : Feature<WeatherState>
    {
        public override string GetName() => "Weather";

        protected override WeatherState GetInitialState()
             => new WeatherState(isLoading: false);
    }
}
