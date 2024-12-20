using LabsManager.Infrastructure;
using LabsManager.Infrastructure.Repository;
using LabsManager.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Data base
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Add services to the container.

builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPassRepository,PassRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<ILabsRepository, LabsRepository>();
builder.Services.AddScoped<ILabsService, LabsService>();
builder.Services.AddScoped<IPassService, PassService>();



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
