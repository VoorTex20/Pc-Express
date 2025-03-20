using Microsoft.EntityFrameworkCore;
using Pc_Express.Context;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Obtém a string de conexão do appsettings.json
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configura o DbContext para MySQL
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Adiciona os serviços do MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Verifica se não está em ambiente de desenvolvimento
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Segurança adicional para HTTPS
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
