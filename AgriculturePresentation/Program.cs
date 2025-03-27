using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework;
using DataAccessLayer.Contexts;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Dependency Injection için servisleri ekleme
builder.Services.ContainerDependencies();

// Database baðlama iþlemi
builder.Services.AddDbContext<AgricultureContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AgricultureContext>()
    .AddDefaultTokenProviders();

// Identity cookie ayarlarýný özelleþtiriyoruz
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index";  // Giriþ yapmamýþ kullanýcýlarý buraya yönlendir
    options.AccessDeniedPath = "/Login/AccessDenied"; // Yetkisiz giriþlerde yönlendirme
    options.SlidingExpiration = true; // Oturum süresini dinamik olarak uzat
});


// Yetkilendirme ve Kimlik Doðrulama
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index";  // Kullanýcý giriþ yapmamýþsa Login/Index sayfasýna yönlendirme
    });

var app = builder.Build();

// Middleware yapýlandýrmalarý
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Login}/{action=Index}/{id?}"); // Ýlk açýlýþ sayfasýný Login/Index olarak ayarladýk
});

app.Run();
