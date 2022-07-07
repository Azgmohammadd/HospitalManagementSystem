using HospiotalServiceHub;
using HospiotalServiceHub.IServices;
using HospiotalServiceHub.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var MyPolicy = "MyPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyPolicy, p => p.WithOrigins("*").AllowAnyMethod().AllowAnyHeader());
});
//TODO: configuration chert zadam?? dorost bayad beshe
builder.Services.Configure<HospitalDBConfig>(builder.Configuration);

// az to stack bardashtam nmidonam chie
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Add services to the container.
builder.Services.AddSingleton<IDbClient, DbClient>(); //chon to tool barname dar hale ejrast?
builder.Services.AddScoped<IPatientService, PatientService>();
//builder.Services.AddScoped<IDoctorService, DoctorService>();
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

app.UseCors("MyPolicy");


app.UseHttpsRedirection();

app.UseRouting();

app.UseCors (MyPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
