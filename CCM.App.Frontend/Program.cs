
using System.Data.Common;
using CCM.App.Dominio;
using CCM.App.Persistencia;
using Microsoft.EntityFrameworkCore;
//using ContosoUniversity.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

//builder.Services.AddDbContext<CCM.App.Persistencia.AppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CCM_Data")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
