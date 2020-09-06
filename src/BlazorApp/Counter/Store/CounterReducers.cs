// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Counter.Store
{
    using Fluxor;

    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action)
            => state with { Count = state.Count + 1 };

        [ReducerMethod]
        public static CounterState ReduceResetCounterAction(CounterState state, ResetCounterAction action)
            => state with { Count = 0 };
    }
}
