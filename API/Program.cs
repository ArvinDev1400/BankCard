using Application.Interfaces;
using Application.Services.AddCard;
using Application.Services.GetList;
using Persistents.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>();



builder.Services.AddScoped<IApplicationDbContext , ApplicationDbContext>();
builder.Services.AddScoped<IAddCardService , AddCardService>();
builder.Services.AddScoped<IGetCardListService , GetCardListService>();

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
