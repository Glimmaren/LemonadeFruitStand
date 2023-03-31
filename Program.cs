using LemonadeStand;
using LemonadeStand.Interfaces;
using LemonadeStand.Repositories;
using LemonadeStand.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IRecipeService,RecipeService>();
builder.Services.AddScoped<IFruitPressService,FruitPressService>();
builder.Services.AddScoped<IRecipeRepository,RecipeRepository>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
