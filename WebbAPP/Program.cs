using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebbAPP.Contexts;
using WebbAPP.Helpers.Repositories;
using WebbAPP.Helpers.Services;
using WebbAPP.Models.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));


builder.Services.AddScoped<ProductEntityRepo>();
builder.Services.AddScoped<ContactFormRepo>();


builder.Services.AddScoped<ProductService>();


builder.Services.AddIdentity<IdentityUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
