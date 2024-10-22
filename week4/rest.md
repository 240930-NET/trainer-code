## Status Codes

**Ranges:**
- 1** - Informational
- 2** - Success (200OK, 201Created)
- 3** - Redirect (301 Moved Permanently)
- 4** - Client Error (404 Not Found)
- 5** - Internal Server Error (500 Internal Server Error)

## Consuming and Exposing API

- Define Resource and URI (resource: expense, uri: /getAllExpenses, /AddNewExpense)
- Choose HTTP Methods (GET, POST, PUT, PATCH, DELETE)
- Design Representation (JSON, XML)
- Implement Logic (Create controllers that handle the request and send the response)
- Implement Error Handling(Create status codes for error handling, create guidelines for error handling)
- Document your API

## Dependencies lifecycle

1. AddScoped - created during HTTP req, and alive only during the request
```
services.AddScoped<IMyService, MyService()>
```
(Good for web services)

2. AddTransient - new instance is created every time it is requsted. 
```
services.AddTransient<IMyService, MyService()>
```
(Good for something stateless and lightweight)

3. AddSingleton - created only once and shared through all app's lifetime.

```
services.AddSingleton<IMyService, MyService()>
```

Good for configuration and caching.