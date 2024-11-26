using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Services;
using ReservasHoteleriaWeb;
using ReservasHoteleriaWeb.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IReservaService, ReservaService>();
builder.Services.AddScoped<IHabitacionService, HabitacionService>();
builder.Services.AddScoped<IServicioService, ServicioService>();
builder.Services.AddScoped<IServicioAdicionalService, ServicioAdicionalService>();
builder.Services.AddScoped<IEmpleadosService, EmpleadosService>();
builder.Services.AddScoped<FirebaseAuthService>();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
