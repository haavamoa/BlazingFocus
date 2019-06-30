using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazingFocus
{
    public static class HTMLElementExtensions
    {
        /// <summary>
        /// Tries to focus a HTML element in the DOM.
        /// </summary>
        /// <param name="elementRef">The element to focus</param>
        /// <param name="jsRuntime">The JavaScript RunTime to use to interop with JavaScript, this should be injected by the caller</param>
        /// <returns>A boolean value to indicate if the HTML element got focus</returns>
        public static Task<bool> TryFocus(this Microsoft.AspNetCore.Components.ElementRef elementRef, IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<bool>("blazingFocus.focusElement", elementRef);
        }

        /// <summary>
        /// Tries to un-focus a HTML element in the dom.
        /// </summary>  
        /// <param name="elementRef">The element to un-focus</param>
        /// <param name="jsRuntime">The JavaScript RunTime to use to interop with JavaScript, this should be injected by the caller</param>
        /// <returns>A boolean value to indicate if the HTML element got un-focused</returns>
        public static Task<bool> TryUnFocus(this Microsoft.AspNetCore.Components.ElementRef elementRef, IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<bool>("blazingFocus.blurElement", elementRef);
        }

        /// <summary>
        /// Check if the HTML element has focus in the DOM.
        /// </summary>
        /// <param name="elementRef">The element to check for focus</param>
        /// <param name="jsRuntime">The JavaScript RunTime to use to interop with JavaScript, this should be injected by the caller</param>
        /// <returns>A boolean value to indicate if the HTML element has focus</returns>
        public static Task<bool> HasFocus(this Microsoft.AspNetCore.Components.ElementRef elementRef, IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<bool>("blazingFocus.hasElementFocus", elementRef);
        }
    }   
}
