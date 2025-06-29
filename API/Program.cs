using API.Context;
using API.Services.Acoes;
using API.Services.Entradas;
using API.Services.Poupancas;
using API.Services.Saidas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEntradaInterface, EntradaService>();
builder.Services.AddScoped<ISaidaInterface, SaidaService>();
builder.Services.AddScoped<IPoupancaInterface, PoupancaService>();
builder.Services.AddScoped<IAcoesInterface, AcoesService>();

var connectionDb = builder.Configuration.GetConnectionString("AppDbConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionDb));
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
