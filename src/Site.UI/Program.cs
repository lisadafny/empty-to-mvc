using Site.UI.Config.Command;
using Site.UI.Config.Repository;
using Site.UI.Config.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigCommand();
builder.Services.ConfigService();
builder.Services.ConfigRepository();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if(app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
