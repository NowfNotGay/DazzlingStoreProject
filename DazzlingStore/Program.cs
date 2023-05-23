using DazzlingStore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectString = builder.Configuration["ConnectionStrings:RootString"];

builder.Services.AddDbContext<DatabaseContext>(op=> op.UseLazyLoadingProxies().UseSqlServer(connectString));

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");

app.Run();
