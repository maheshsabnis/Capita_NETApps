//`1. Host Builder
using Core_API.CustomActionFilters;
using Core_API.CustomMiddlewares;
using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//1. Adding the UcompanyContext in DI Container
builder.Services.AddDbContext<UcompanyContext>(options =>{
    /* Define the ConnectionString*/
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnStr"));
});


//1.a. Register the CapSecurityDbContext class in DI Container as DbContext
builder.Services.AddDbContext<CapSecurityDbContext>(options => {
    /* Define the ConnectionString*/
    options.UseSqlServer(builder.Configuration.GetConnectionString("SecurityConnStr"));
});


// 1.b. Register the Identity Service to Register and Resolve
// UserManager<IdentityUser>, RoleManager<IdentityRole>, and SignInManager<IdentityUser>
// This will write and read the Users' and Roles' infromation from the
// Database using EF Core
builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<CapSecurityDbContext>();

// 1.c. Define Policies

builder.Services.AddAuthorization(options => 
{
    // 1.c.1. Add the Read Policy
    options.AddPolicy("readpolicy", policy => policy.RequireRole("Manager", "Clerk", "Operator"));
    // 1.c.2. Add the Add/Edit Policy
    options.AddPolicy("addeditpolicy", policy => policy.RequireRole("Manager", "Clerk"));
    // 1.c.3. Add the Delete Policy
    options.AddPolicy("deletepolicy", policy => policy.RequireRole("Manager"));
});
 

// 2 Registering the Custom Department and Employee Services

builder.Services.AddScoped<IDataAccessService<Department, int>, DepartmentDataService>();
builder.Services.AddScoped<IDataAccessService<Employee, int>, EmployeeDataService>();
// Register the AuthenticateService
builder.Services.AddScoped<AuthenticationService>();


/* Add the Cors Origin Resource Sharing (CORS) service*/
builder.Services.AddCors(options => options.AddPolicy("corspolicy", policy=> 
{ 
    // Any Client origin can access REST API with Any HTTP Header and ANY HTTP Method 
    policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
  //  policy.WithOrigins("https://www.xyz.com").WithMethods("GET", "POST");
}));


// ASP.NET Core Core Services
// AddControllers(): For Request Processing of API Controllers
builder.Services.AddControllers()
     /* Override a Default Camel Casing JSON Response with the Pascal Case or based on names of properties in Serialization*/
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy =null)
    // The Action Filter at Global Level
    .AddMvcOptions(options=> 
    {
        options.Filters.Add(new LogFilterAttribute());
    });
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

// Add CORS Middleware based on POLICY
app.UseCors("corspolicy");
// Add the Authentication Middleware
// These Middlewares are based on AddIdentity() service 
app.UseAuthentication();
app.UseAuthorization();

/*
   Register the Custom Exception Milddleware
 */

app.UseAppExceptionHandler();


/*
   Read the URL and Match it with the Route Table (No Direct Route Table as such)
   The MapControllers() is responsible to Read the HTTP URL, and HTTP Request Type (GET/POST/PUT/DELETE)
 */
app.MapControllers();
/* https://server/Application/api/controller/action */

app.Run();
