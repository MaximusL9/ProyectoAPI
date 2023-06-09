using Microsoft.EntityFrameworkCore;
using ProyectoAPI;
using ProyectoAPI.Data;
using ProyectoAPI.Repository;
using ProyectoAPI.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProyectContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(ConfiguracionDeMapeo));

//Inyecci�n de los Repository
builder.Services.AddScoped<ITrabajadorRepository, TrabajadorRepository>();
builder.Services.AddScoped<IProductoRepositery, ProductoRepositery>();
builder.Services.AddScoped<IVentasRepositery, VentaRepositery>();
builder.Services.AddScoped<IClientesRepositery, ClienteRepositery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
