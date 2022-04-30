using Microsoft.EntityFrameworkCore;
using Sesion04_MVC.DatabaseFirst.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Get ConnectionString DevConnection
var connectionString = builder.Configuration.GetConnectionString("DevConnection");
//Add dbcontext
builder.Services.AddDbContext<Qatar2022DbContext>(options => options.UseSqlServer(connectionString));

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
