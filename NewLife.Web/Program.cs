using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newlife.Web.Core.Interfaces;
using Newlife.Web.Repositories;
using NewLife.Web.Data;
using NewLife.Web.Mapping;
using NewLife.Web.Seed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI().AddDefaultTokenProviders();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddMapping();
builder.Services.AddControllersWithViews().AddViewLocalization(op => op.ResourcesPath = "Resources");
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

await app.Services.SeedAdminAndRolesData();

app.UseRequestLocalization(options =>
{
    options.AddSupportedCultures(new string[] { "ar-SA", "en-US" });
    options.AddSupportedUICultures(new string[] { "ar-SA", "en-US" });
    options.SetDefaultCulture("ar-SA");
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
           name: "Admin",
           areaName: "Admin",
           pattern: "Admin/{controller=Home}/{action=Index}/{id?}");


    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.MapRazorPages();

app.Run();
