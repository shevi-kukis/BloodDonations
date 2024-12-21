using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
using BloodDanations.Core.IcoinService;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data;
using BloodDanations.Data.Data;

using BloodDanations.Service.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDonorService, DonorService>();
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<IBloodDoseService, BloodDoseService>();
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<ICompatibilityCheckService, CompatibilityCheckServies>();


builder.Services.AddScoped(typeof( IRepositoryManager),typeof( RepositoryManager));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = BloodDonations; Integrated Security = true; "));
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
