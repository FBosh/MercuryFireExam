using MercuryFireExam.Repositories;
using MercuryFireExam.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services
builder.Services.AddScoped<IACPDService, ACPDService>();

//Repositories
builder.Services.AddScoped<IACPDRepository, ACPDRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
