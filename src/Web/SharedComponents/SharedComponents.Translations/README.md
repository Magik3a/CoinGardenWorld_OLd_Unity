Set the `BlazorWebAssemblyLoadAllGlobalizationData` property to `true` in the project file:

```xml
<PropertyGroup>
  <BlazorWebAssemblyLoadAllGlobalizationData>true</BlazorWebAssemblyLoadAllGlobalizationData>
</PropertyGroup>
```

The app's culture in a Blazor WebAssembly app is set using the Blazor framework's API. A user's culture selection can be persisted in browser local storage.

In the `wwwroot/index.html` file after Blazor's `<script>` tag and before the closing `</body>` tag, provide JS functions to get and set the user's culture selection with browser local storage:

```html
<script>
  window.blazorCulture = {
    get: () => window.localStorage['BlazorCulture'],
    set: (value) => window.localStorage['BlazorCulture'] = value
  };
</script>