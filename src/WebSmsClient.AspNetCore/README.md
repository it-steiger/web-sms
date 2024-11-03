#### A library to integrage ITSteiger.WebSmsClient i an ASPNETCORE Project
# Get Started

Add these lines of code to your Program.cs 
```csharp
builder.Services.AddWebSmsClient(options => options
    .UseAccessToken(builder.Configuration.GetValue<string>("Access_Token")!));
```

##### IMPORTANT NOTE!
The WebSmsClient inject a HTTP Client through Dependency Injection (DI).
A common way is to add these line before you call builder.Services.AddWebSmsClient...
```csharp
builder.Services.AddHttpClient();
```

### More details you can find in the /examples directory
