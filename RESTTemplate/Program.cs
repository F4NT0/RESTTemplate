using RESTTemplate.Services;
using RESTTemplate.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/**
 * -------------------------
 *  INJEÇÃO DE DEPENDÊNCIAS
 * -------------------------
 * 
 * Aqui iremos colocar os Services e suas Implementations
 * para ser usado pela API REST
 */

builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
