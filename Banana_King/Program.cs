using Banana_King.Areas.Identity.Data;
using Banana_King.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using QRCoder;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FruitEmpireAuthConnection") ?? throw new InvalidOperationException("Connection string 'FruitEmpireAuthConnection' not found.");

builder.Services.AddDbContext<FruitEmpireAuth>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<RazorPagesBananaUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FruitEmpireAuth>();

// Add services to the container.
builder.Services.AddRazorPages(options =>
    options.Conventions.AuthorizePage("/BananaOperations", "Admin"));
builder.Services.AddTransient<IEmailSender, EmailSenderService>();
// Registered as a singleton service in the IoC container
builder.Services.AddSingleton(new QRCodeService(new QRCodeGenerator()));
builder.Services.AddAuthorization(options =>
    options.AddPolicy("Admin", policy =>
        policy.RequireAuthenticatedUser()
            .RequireClaim("IsAdmin", bool.TrueString)));

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
