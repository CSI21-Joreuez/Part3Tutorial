using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
        name: "Default",
        pattern: "{controller=Home}/{action=Index}/{id?}",
        defaults: new { Controller = "Home", action = "Index" }
    );

app.Run();
