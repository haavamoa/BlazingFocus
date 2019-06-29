[![NuGet](https://img.shields.io/nuget/v/BlazingFocus.svg?maxAge=2592000)](https://www.nuget.org/packages/BlazingFocus)

# BlazingFocus
A Blazor library to set focus on a HTML element based on a `id`.

# Installing

By using NuGet:

`PM> Install-Package BlazingFocus`

# Usage

> In this scenario we want to set focus to a text input entry when the web app is started. This API can be used in whatever scenario (on a button click, when navigating etc.).

- Inject `BlazingFocus` and `IJSRuntime` in the top of the `.razor` page that you want to set focus:
  
```html
@page "/"
@using BlazingFocus
@inject IJSRuntime JsRunTime

<h1>My Page</h1>

Welcome to my page
```

- Create an element with an `id` that you want to set focus to:

```html
@page "/"
@using BlazingFocus
@inject IJSRuntime JsRunTime

<h1>My Page</h1>

Welcome to my page

<input type="text" id="myEntry"/> 
```

- Override `Task OnAfterRenderAsync` and call `BlazingFocus.TryFocus` with the id of `myEntry`.
  
```csharp
@code
{

    protected override async Task OnAfterRenderAsync()
    {
        await BlazingFocus.TryFocus(JsRunTime, "myEntry");
    }

}
```

**Your text input entry now has focus!** :boom:

# Remarks

I have only been able to make this work on a `client-side` Blazor project (`dotnet new blazor` and `dotnet new blazorhosted`).
In a Blazor `server-side` project (`dotnet new blazorserverside`) the `content` folder will not be injected to `wwwroot`. This means that the javascript interopt will not find my javascript when trying to set focus.
