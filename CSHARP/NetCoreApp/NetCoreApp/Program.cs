using Microsoft.EntityFrameworkCore;
using NetCoreApp.Model.Context;
using System.Data.Common;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DemosContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
});
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
