// builder => sert � construire et configurer l'application

var builder = WebApplication.CreateBuilder(args);

// Ajout de services.
// Des classes qui donnent des fonctionnalit�s r�utilisables dans l'application
// Ex : pour la BDD, pour EfCore, Repositories, ...
builder.Services.AddControllersWithViews();

var app = builder.Build(); //m�thode qui passe d'une application "en construction" � une application pr�te

// Ajout de Middlewares et configuration post build

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ajout de la configuration de la route par d�faut (default)
// elle d�finit un pattern de base pour l'acc�s � nos controllers => /Home/Privacy
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ajout d'une 2e configuration avec une route "/test" qui redirige vers Privacy
app.MapControllerRoute(
    name: "customRoute",
    pattern: "test", 
    new
    {
        Controller = "Home",
        Action = "Privacy"
    });

app.Run();
