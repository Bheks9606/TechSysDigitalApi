using Microsoft.EntityFrameworkCore;
using TechSysDigitalApi.Configurations;
using TechSysDigitalApi.Contracts;
using TechSysDigitalApi.Data;
using TechSysDigitalApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//register the musician db context 
builder.Services.AddDbContext<MusicianDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("MusicianCS"), 
    b => b.MigrationsAssembly("TechSysDigitalApi")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IMusicianRepository, MusicianRepository>();

builder.Services.AddAutoMapper(typeof(MapperConfig));


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
