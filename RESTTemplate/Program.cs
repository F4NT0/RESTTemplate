using Microsoft.EntityFrameworkCore;
using RESTTemplate.Model.Context;
using RESTTemplate.Repository;
using RESTTemplate.Repository.Implementations;
using RESTTemplate.Services;
using RESTTemplate.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/**
 * -----------------------------
 * CONEXÃO COM O BANCO DE DADOS
 * -----------------------------
 * 
 * Aqui chamamos o Context criado para nos conectar com o banco de dados
 * onde defini o SQLite como banco de testes
 */
var connection = builder.Configuration["SQLiteConnection:SQLiteConnectionString"]; // mesmo nome que se encontra no appsettings.json
builder.Services.AddDbContext<SQLiteContext>(options => options.UseSqlite(connection));


/**
 * -------------------------
 *  INJEÇÃO DE DEPENDÊNCIAS
 * -------------------------
 * 
 * Aqui iremos colocar os Services e suas Implementations.
 * Aqui iremos colocar os Repositorys e suas Implementations.
 */

builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
