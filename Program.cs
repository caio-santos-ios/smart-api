using smartbr_api_clients.Services;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Repository;
using MongoDB.Driver;
using smartbr_api_clients.Commands.Handler;
using MediatR;
using System.Reflection;
using smartbr_api_clients.Queries.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Configuração do MongoDB
var mongoDbSettings = builder.Configuration.GetSection("MongoDBSettings");
var mongoClient = new MongoClient(mongoDbSettings["ConnectionString"]);
var database = mongoClient.GetDatabase(mongoDbSettings["DatabaseName"]);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<MongoDbService>();
builder.Services.AddControllers();

// Registro do MongoDatabase
builder.Services.AddSingleton<IMongoDatabase>(database);

// Registro dos Serviços e Repositorios
builder.Services.AddSingleton<IClientService, ClientService>();
builder.Services.AddSingleton<IClientRepository, ClientRepository>();
builder.Services.AddScoped<CreateClientCommandHandler>();
builder.Services.AddScoped<GetAllClientQueryHandler>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
app.UseCors(x => x
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());
app.Run();