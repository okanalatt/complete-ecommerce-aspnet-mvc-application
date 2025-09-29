using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args); // Uygulama yapýlandýrýcýsýný oluþtur

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Veritabaný baðlantýsýný yapýlandýr

builder.Services.AddScoped<IActorsService, ActorsService>(); // Servisleri DI konteynerine ekle
builder.Services.AddScoped<IProducersService, ProducersService>(); 

builder.Services.AddControllersWithViews(); // MVC'yi ekle


var app = builder.Build(); // Uygulamayý oluþtur


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Movies/Error"); // Hata sayfasýný yapýlandýr
    app.UseHsts();
}


app.UseHttpsRedirection(); // HTTPS yönlendirmesini etkinleþtir
app.UseStaticFiles(); // Statik dosyalarý sun
app.UseRouting(); // Yönlendirmeyi etkinleþtir
app.UseAuthorization(); // Yetkilendirmeyi etkinleþtir

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");




app.Run(); // Uygulamayý çalýþtýr
