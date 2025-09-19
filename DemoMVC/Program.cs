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
        ?? throw new Exception("Votre token n'est pas configur�");
    client.DefaultRequestHeaders
        .Add("Authorization", "Bearer " + token);
    return client;
});
    
// ressource cr�� � chaque demande
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

app.Run();
