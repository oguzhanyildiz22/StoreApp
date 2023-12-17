using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using StoreApp.Models;
using StoreApp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    // Kullanıcı adı ve şifre gereksinimlerini özelleştirmek için gerekirse burada ayarlamalar yapabilirsiniz.
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = true;
    options.Lockout.MaxFailedAccessAttempts = 5;
})
.AddEntityFrameworkStores<RepositoryContext>()
.AddDefaultTokenProviders();

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

SeedData.Initialize(app.Services).Wait();

app.Run();
