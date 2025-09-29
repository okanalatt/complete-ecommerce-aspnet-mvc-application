using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args); // Uygulama yap�land�r�c�s�n� olu�tur

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Veritaban� ba�lant�s�n� yap�land�r

builder.Services.AddScoped<IActorsService, ActorsService>(); // Servisleri DI konteynerine ekle
builder.Services.AddScoped<IProducersService, ProducersService>(); 

builder.Services.AddControllersWithViews(); // MVC'yi ekle


var app = builder.Build(); // Uygulamay� olu�tur


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Movies/Error"); // Hata sayfas�n� yap�land�r
    app.UseHsts();
}


app.UseHttpsRedirection(); // HTTPS y�nlendirmesini etkinle�tir
app.UseStaticFiles(); // Statik dosyalar� sun
app.UseRouting(); // Y�nlendirmeyi etkinle�tir
app.UseAuthorization(); // Yetkilendirmeyi etkinle�tir

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");




app.Run(); // Uygulamay� �al��t�r
