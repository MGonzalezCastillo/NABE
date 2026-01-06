using Microsoft.EntityFrameworkCore;
using Nabe.Data;
using NABE.Data;

var builder = WebApplication.CreateBuilder(args);

// ================== REGISTRO DE SERVICIOS ==================

// DbContext (EF Core)
builder.Services.AddDbContext<NabeDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// DALs (Stored Procedures)
builder.Services.AddScoped<PerfilesDAL>();
builder.Services.AddScoped<CategoriasDAL>();
builder.Services.AddScoped<ProveedoresDAL>();
builder.Services.AddScoped<UsuariosDAL>();

// MVC
builder.Services.AddControllersWithViews();

// ===========================================================

var app = builder.Build();

// ================== PIPELINE ==================
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
