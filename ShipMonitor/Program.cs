using Microsoft.EntityFrameworkCore;
using ShipMonitor;
using ShipMonitor.Business;
using ShipMonitor.Database;
using ShipMonitor.Integrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddLogging()
    .AddHttpClient();

builder.Services.AddScoped<IShipBusiness, ShipBusiness>();
builder.Services.AddScoped<IAisApiClient, AisApiClient>();

builder.Services.AddDbContext<ShipMonitorDbContext>(c =>
{
    c.UseNpgsql(builder =>
    {
        builder.MigrationsHistoryTable(ShipMonitorDbContext.MIGRATIONS_HISTORY_TABLE_NAME, ShipMonitorDbContext.SCHEMA_NAME);
    })
    .UseSnakeCaseNamingConvention();
});

builder.Services.AddAutoMapper(c =>
{
    c.AddProfile<Mappings>();
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
