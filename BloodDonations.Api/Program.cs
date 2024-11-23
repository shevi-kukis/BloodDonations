using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
using BloodDanations.Core.IcoinService;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data;
using BloodDanations.Data.Data;
using BloodDanations.Data.Repository;
using BloodDanations.Service.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped< IDonorService,DonorService>();
builder.Services.AddScoped<IDonorRepository, DonorRepository>();
builder.Services.AddSingleton<DataContext<Donor>>();
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddSingleton<DataContext<Patient>>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
