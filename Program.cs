using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Reserva.Data;
using Reserva.Repositories;
using Reserva.Services;

var builder = WebApplication.CreateBuilder(args);

//load the enviroment variables

Env.Load(); // callin all the variables
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabase = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");


var ConnectionDB = $"server={dbHost}; port={dbPort}; database={dbDatabase}; uid={dbUser}; password={dbPassword}";
builder.Services.AddDbContext<ApplicationDbContext>(Options => Options.UseMySql(ConnectionDB, ServerVersion.Parse("8.0.20-mysql")));


// Add services to the container.
builder.Services.AddScoped<IRoomRepository, RoomServices>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    C =>
{
    C.SwaggerDoc("v1", new OpenApiInfo { Title = "NEWLIBRARY", Version = "V1" });

    C.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });

    C.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });

    //Habilita las anotaciones Swagger
    C.EnableAnnotations();
}
);

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
