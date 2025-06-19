using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]);
});

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache(); 
builder.Services.AddSession();
builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp)); 
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();
app.UseSession();

// Custom route mappings
app.MapControllerRoute(
    name: "catpage",
    pattern: "{category}/Page{productPage:int}",
    defaults: new { Controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "page",
    pattern: "Page{productPage:int}",
    defaults: new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute(
    name: "category",
    pattern: "{category}",
    defaults: new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute(
    name: "pagination",
    pattern: "Products/Page{productPage}",
    defaults: new { Controller = "Home", action = "Index", productPage = 1 });

app.MapRazorPages();
app.MapDefaultControllerRoute();

// Seed data
SeedData.EnsurePopulated(app);

// Run the app
app.Run();
