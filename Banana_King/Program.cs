using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Banana_King.Areas.Identity.Data;
using Banana_King.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FruitEmpireAuthConnection") ?? throw new InvalidOperationException("Connection string 'FruitEmpireAuthConnection' not found.");

builder.Services.AddDbContext<FruitEmpireAuth>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<RazorPagesBananaUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FruitEmpireAuth>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IEmailSender, EmailSenderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
