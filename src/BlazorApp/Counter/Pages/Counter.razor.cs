// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Counter.Pages
{
    using BlazorApp.Counter.Store;
    using Fluxor;
    using Microsoft.AspNetCore.Components;

    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        private void IncrementCount()
        {
            Dispatcher.Dispatch(new IncrementCounterAction());
        }

        private void ResetCount()
        {
            Dispatcher.Dispatch(new ResetCounterAction());
        }
    }
}
