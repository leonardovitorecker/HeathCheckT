using HeathCheck1.Database;
using HeathCheck1.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(
    options => options.UseNpgsql(
        "Host=localhost;Port=5432;Database=Projetoteste1;User Id=postgres; Password=postgres;"));
builder.Services.AddTransient<IEspecialistaRepositorio, EspecialistaRepositorio>();

builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddTransient<IConsultaRepositorio, ConsultaRepositorio>();
var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Busca}/{action=BuscaEspecialista}/{id?}");

app.Run();
