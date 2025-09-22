using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IActorsService, ActorsService>();

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");



AppDbInitializer.Seed(app); // Uygulama açýlýrken rastgele veri eklenir

app.Run();
