using HospitalService.Domain.Contracts;
using HospitalService.Domain.Contracts.Repositories;
using HospitalService.Infrastructure;
using HospitalService.Infrastructure.Database;
using HospitalService.Infrastructure.Repories;
using HospitalService.Shared.EmailServices;
using HospitalService.Shared.EmailServices.EmailContracts;
using HospitalService.Shared.EmailServices.EmailDomaines.EmailModels;
using HospitalService.WebApi.Extenstions;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddJwtAndExternalAuthentication(builder.Configuration);
builder.Services.AddDbContext<HospitalDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("HospitalDbContext")));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));



builder.Services.AddSingleton<IMailService, MailService>();
builder.Services.AddScoped<RepositoryProvider>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ICategoryRepository, Categorypository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryDoctorRepository, CategoryDoctorRepository>();
builder.Services.AddScoped<ICalendaryRepository, CalendaryReposition>();


builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});

app.MapControllers();

app.Run();
