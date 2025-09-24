using DemoMVC;
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movie}/{action=Index}/{id:int?}");

// app.Run();

//List<string> strings = ["Mohamed", "Khun", "Wendy"];

//List<string> filteredStrings = strings
//    .Where(s => s.Contains("n"))
//    .Select(s => s.ToUpper())
//    .ToList();

//foreach (string s in strings)
//{
//    if(s.Contains("n"))
//    {
//        filteredStrings.Add(s);
//    }
//}

// Console.WriteLine(string.Join(",", filteredStrings));

var db = app.Services.CreateScope()
    .ServiceProvider.GetService<StockContext>();

var p = db.Products
    .Where(p => p.LastBuyingPrice < 30)
    .Select(p => new { 
        // selecttionner et mettre un alias
        Name = p.Name.ToUpper(), 
        Prix = p.Price 
    })
    .ToList();

foreach (var product in p)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Prix);
    Console.WriteLine("---------------------");
}


// 1. select lastName, firstName FROM customer
// 2. selectionner la ref, nom, prenom du client
// dont la réference est C005
// 3. selectionner le nom, le prenom, l'email en majuscule
// des clients dont le  le nom ou le prenom  commence par "a"
// 4. selectionner le nom, le prenom, l'email
// des 2 premiers clients triés
// par ordre decroissant sur le nom dont le nom ou le prenom commence par "a"