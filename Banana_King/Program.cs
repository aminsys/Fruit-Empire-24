using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Banana_King.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FruitEmpireAuthConnection") ?? throw new InvalidOperationException("Connection string 'FruitEmpireAuthConnection' not found.");

builder.Services.AddDbContext<FruitEmpireAuth>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FruitEmpireAuth>();

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

app.MapRazorPages();

app.Run();
