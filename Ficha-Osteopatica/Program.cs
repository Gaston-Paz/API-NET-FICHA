using Ficha_Osteopatica.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InjectServices.InjectLogics(builder.Services);
InjectServices.InjectRepositories(builder.Services);
InjectServices.InjectDB(builder.Services);
InjectServices.InjectAutoMapper(builder.Services);

var app = builder.Build();

// Validar configuración de AutoMapper
AutoMapperConfiguration.ValidateConfiguration(app.Services);

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
