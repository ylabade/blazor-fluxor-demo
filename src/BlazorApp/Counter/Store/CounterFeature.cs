// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Counter.Store
{
    using Fluxor;

    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState()
             => new CounterState(count: 0);
    }
}
