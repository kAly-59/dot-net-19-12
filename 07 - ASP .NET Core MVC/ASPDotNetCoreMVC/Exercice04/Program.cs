using Exercice04.Data;
using Exercice04.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<AnimalFakeDb>();


// m�thodes � utiliser pour enregistrer un db context et pouvoir utiliser efcore

// - dans le cas o� on utilise OnConfiguring pour le ConnectionString
// builder.Services.AddDbContext<ApplicationDbContext>();

// dans le cas o� on utilise le fichier appsettings.json pour le ConnectionString
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<AnimalRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Animal}/{action=Index}/{id?}");

app.Run();
