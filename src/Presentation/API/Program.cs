using Application.Interfaces;
using Application.Mapping;
using Application.Services.Abstract;
using Application.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repository;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ERandevuDB>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ERandevuDB")));

builder.Services.AddControllers();
builder.Services.AddScoped(typeof(IGenericServices<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IClinicServices,ClinicServices>();
builder.Services.AddScoped<IPatientServices,PatientServices>();
builder.Services.AddScoped<IDoctorServices, DoctorServices>();
builder.Services.AddScoped<IAppointmentServices, AppointmentServices>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddAutoMapper(typeof(GeneralMapping));

builder.Services.AddOpenApi();

var app = builder.Build();
builder.Services.AddEndpointsApiExplorer();

app.MapScalarApiReference(
    opt =>
    {
        opt.Title = "ERandevu API V1";
        opt.Theme = ScalarTheme.BluePlanet;
        opt.DefaultHttpClient = new(ScalarTarget.Http, ScalarClient.Http11);
       
    });

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
