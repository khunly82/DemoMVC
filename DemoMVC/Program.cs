using DemoMVC;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ressource unique
//builder.Services.AddSingleton

// ressource unique par requete
builder.Services.AddScoped(_ =>
{
    HttpClient client = new HttpClient();
    string token = builder.Configuration["API_TOKEN"]
        ?? throw new Exception("Votre token n'est pas configuré");
    client.DefaultRequestHeaders
        .Add("Authorization", "Bearer " + token);
    return client;
});

builder.Services.AddScoped(_ =>
{
    SmtpClient client = new();
    client.Host = "sandbox.smtp.mailtrap.io";
    client.Port = 25;
    client.Credentials = new NetworkCredential
    {
        UserName = "d50f59b2cc8cfb",
        Password = "a71635274f4a9b"
    };
    client.EnableSsl = true;
    client.Timeout = 5000;
    return client;
});

builder.Services.AddDbContext<StockContext>(o =>
{
    // je veux me connecter à SqlServer
    // nécessite le package Microsoft.EntityFrameWorkCore.SqlServer
    o.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(o => {
        o.LoginPath = "/login";
        o.LogoutPath = "/logout";
        o.AccessDeniedPath = "/login";
        o.ExpireTimeSpan = TimeSpan.FromHours(1);
    });

    
// ressource créé à chaque demande
// builder.Services.AddTransient

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movie}/{action=Index}/{id?}");

app.Run();

