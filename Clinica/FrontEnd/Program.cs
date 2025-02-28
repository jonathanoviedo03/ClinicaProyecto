using FrontEnd.Helpers.Implementations;
using FrontEnd.Helpers.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x => x.LoginPath = "/account/login");

builder.Services.AddSession();

builder.Services.AddHttpClient<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<ISecurityHelper, SecurityHelper>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IPrecioHelper, PrecioHelper>();
builder.Services.AddScoped<IClinicaHelper, ClinicaHelper>();
builder.Services.AddScoped<IDoctorHelper, DoctorHelper>();
builder.Services.AddScoped<IHorarioHelper, HorarioHelper>();
builder.Services.AddScoped<IEspecialidadHelper, EspecialidadHelper>();
builder.Services.AddScoped<ICitaHelper, CitaHelper>();
builder.Services.AddScoped<IUsuarioHelper, UsuarioHelper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
