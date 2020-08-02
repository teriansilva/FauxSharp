:warning: **This is still not entirely tested and under development, some things may not work**

# FauxSharp

FauxSharp is a simple C# SDK for communicating with [FauxApi](https://github.com/ndejong/pfsense_fauxapi) on PFSense

## Installation

Use Nuget to install FauxApi Sdk.

```powershell
Install-Package FauxApi
```

## Usage
FauxSharp can be easily used with dependency injection in Asp.net core. Just setup the services like so:
```csharp
services.AddSingleton<IApiBaseService>(x => new ApiBaseService(new ClientBaseOptions("https://pfsense_fauxapi_host","apikey","apisecret",false,true)));
services.AddSingleton<IApiService, ApiService>();
```
The ApiBaseService can also be created without the CLientBaseOptions and you can configure it later, see further down.
You can then inject the service in your own services etc. and call it:
```csharp
await ApiService.SystemStats();
```
If you want to change / set the ClientBaseOptions outside of the service setup, just do this:
```csharp
await ApiBaseService.UpdateConfiguration(new ClientBaseOptions("https://pfsense_fauxapi_host2","apikey2","apisecret2",false,true));
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
