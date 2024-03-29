[![Build Status](https://dev.azure.com/havardmoas/HaavamoaProjects/_apis/build/status/haavamoa.BlazingFocus?branchName=master)](https://dev.azure.com/havardmoas/HaavamoaProjects/_build/latest?definitionId=7&branchName=master)

[![NuGet](https://img.shields.io/nuget/v/BlazingFocus.svg?maxAge=2592000)](https://www.nuget.org/packages/BlazingFocus)

# BlazingFocus

A Blazor library to set focus on a HTML element based on a `ref`.

# Installing

By using NuGet:

`dotnet add package BlazingFocus`

or

`Install-Package BlazingFocus`

# Usage

> In this scenario we want to set focus to a text input entry when the web app is started. This API can be used in whatever scenario (on a button click, when navigating etc.).
> For a example with buttons, please see [here](src/BlazingFocus.TestClients/Client-Side/BlazingFocus.TestClient.Client/Pages/Index.razor)

- Include JavaScript in HTML
  - In Blazor Client side: `wwwroot/index.html`

  - In Blazor Server Side: `Pages/_Host.cshtml`
  
```html
<script src="_content/BlazingFocus/blazingFocus.js"></script>
```

- Add using to `BlazingFocus` and inject `IJSRuntime` in the top of the `.razor` page that you want to set focus:

```html
@page "/"
@using BlazingFocus
@inject IJSRuntime JsRunTime

<h1>My Page</h1>

Welcome to my page
```

- Create an element with an `@ref` that you want to set focus to:

```html
@page "/"
@using BlazingFocus
@inject IJSRuntime JsRunTime

<h1>My Page</h1>

Welcome to my page

<input type="text" @ref="MyEntry"/> 

@code
{
    private ElementRef MyEntry { get; set; }
}

```

- Override `Task OnAfterRenderAsync` and call `MyEntry.TryFocus` with the `IJSRunTime`
  
```csharp
@code
{
    private ElementRef MyEntry { get; set; }

    protected override async Task OnAfterRenderAsync()
    {
        await MyEntry.TryFocus(JsRunTime);
    }

}
```

- **Your text input entry has focus!** :boom:


# Remarks

## Extra

The API also has `UnFocus` and `HasFocus`, theese can be used to un-focus a HTML element and to check if a HTML element has focus.
For a example, please see [here](src/BlazingFocus.TestClients/Client-Side/BlazingFocus.TestClient.Client/Pages/Index.razor)

## Prerelease

Hence that this is a library to use in Blazor, which is still in preview. This means that my project is also in a preview state and bugs may occure.
