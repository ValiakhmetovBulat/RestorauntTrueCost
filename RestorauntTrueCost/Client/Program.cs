using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestorauntTrueCost.Client;
using RestorauntTrueCost.Client.Models.Authentication;
using RestorauntTrueCost.Client.Services;
using RestorauntTrueCost.Client.ViewModels;
using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();


#region ViewModels Injections Services
builder.Services.AddTransient<ILoginViewModel, LoginViewModel>();
builder.Services.AddTransient<IProfileViewModel, ProfileViewModel>();
builder.Services.AddTransient<IFeedbackViewModel, FeedbackViewModel>();
builder.Services.AddTransient<IRegistrationViewModel, RegistrationViewModel>();
builder.Services.AddTransient<IOrderViewModel, OrderViewModel>();
builder.Services.AddTransient<IMenuViewModel, MenuViewModel>();
builder.Services.AddTransient<IOrderPrepareViewModel, OrderPrepareViewModel>();
builder.Services.AddTransient<IOrderHistoryViewModel, OrderHistoryViewModel>();
builder.Services.AddTransient<IOrderManagementViewModel,  OrderManagementViewModel>();
#endregion

#region Services
builder.Services.AddSingleton<ViewNavbarService>();
#endregion


await builder.Build().RunAsync();
