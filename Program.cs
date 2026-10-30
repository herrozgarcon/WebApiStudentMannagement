using Scalar.AspNetCore;
using WebApplication1.Data;
using WebApplication1.Repositories;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<StudentRepo>();

builder.Services.AddScoped<StudentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

