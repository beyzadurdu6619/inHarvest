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

// Dependency Injection i�in servisleri ekleme
builder.Services.ContainerDependencies();

// Database ba�lama i�lemi
builder.Services.AddDbContext<AgricultureContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AgricultureContext>()
    .AddDefaultTokenProviders();

// Identity cookie ayarlar�n� �zelle�tiriyoruz
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index";  // Giri� yapmam�� kullan�c�lar� buraya y�nlendir
    options.AccessDeniedPath = "/Login/AccessDenied"; // Yetkisiz giri�lerde y�nlendirme
    options.SlidingExpiration = true; // Oturum s�resini dinamik olarak uzat
});


// Yetkilendirme ve Kimlik Do�rulama
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
        options.LoginPath = "/Login/Index";  // Kullan�c� giri� yapmam��sa Login/Index sayfas�na y�nlendirme
    });

var app = builder.Build();

// Middleware yap�land�rmalar�
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
        pattern: "{controller=Login}/{action=Index}/{id?}"); // �lk a��l�� sayfas�n� Login/Index olarak ayarlad�k
});

app.Run();
