// Licensed under the MIT License. See License in the project root for license information.

namespace BlazorApp.Counter.Store
{
    public record CounterState
	{
		public CounterState(int count)
		{
			Count = count;
		}

		public int Count { get; set; }
    }
}
