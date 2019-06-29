using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazingFocus
{
    public static class BlazingFocus
    {
        public static async Task<bool> TryFocus(IJSRuntime jsRuntime, string id)
        {
            try
            {
                var wasFocused = await jsRuntime.InvokeAsync<bool>(
                    "blazingFocus.focusElement",
                    id);
                return wasFocused;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return false;
            }
        }
    }   
}
