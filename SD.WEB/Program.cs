using AzureStaticWebApps.Blazor.Authentication;
using Blazored.SessionStorage;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using BlazorPro.BlazorSize;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SD.WEB;
using SD.WEB.Modules.List.Core.TMDB;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();

static void ConfigureServices(IServiceCollection collection, string baseAddress)
{
    collection
        .AddBlazorise(options => options.Immediate = true)
        .AddBootstrapProviders()
        .AddFontAwesomeIcons();

    collection.AddBlazoredSessionStorage(config => config.JsonSerializerOptions.WriteIndented = true);

    collection.AddPWAUpdater();
    collection.AddMediaQueryService();

    collection
        .AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) })
        .AddStaticWebAppsAuthentication();

    collection.AddScoped<Settings>();
    collection.AddScoped<ListService>();
    collection.AddScoped<MediaDetailService>();

    collection.AddLogging(logging =>
    {
        logging.AddProvider(new CosmosLoggerProvider());
    });
}

//static void ConfigureCulture(WebAssemblyHost host)
//{
//    CultureInfo culture;
//    var session = host.Services.GetRequiredService<ISyncSessionStorageService>();
//    var sett = session.GetItem<Settings>("Settings");

//    if (sett != null)
//    {
//        culture = new CultureInfo(sett.Language.GetName(false) ?? "en-US");
//    }
//    else
//    {
//        culture = CultureInfo.CurrentCulture;

//        //save the new settings
//        sett = new Settings(session);
//        session.SetItem("Settings", sett);
//    }

//    CultureInfo.DefaultThreadCurrentCulture = culture;
//    CultureInfo.DefaultThreadCurrentUICulture = culture;
//}