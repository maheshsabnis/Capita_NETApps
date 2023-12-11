//`1. Host Builder
using Core_API.Models;
using Core_API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//1. Adding the UcompanyContext in DI Container
builder.Services.AddDbContext<UcompanyContext>(options =>{
    /* Define the ConnectionString*/
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnStr"));
});

// 2 Registering the Custom Department and Employee Services

builder.Services.AddScoped<IDataAccessService<Department, int>, DepartmentDataService>();

// ASP.NET Core Core Services
// AddControllers(): For Request Processing of API Controllers
builder.Services.AddControllers()
     /* Override a Default Camel Casing JSON Response with the Pascal Case or based on names of properties in Serialization*/
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy =null);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/*Middleware Configuration*/
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
