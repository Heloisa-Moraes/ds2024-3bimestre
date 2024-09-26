using HeroesAPI.Configurations;
using MongoDB.Driver; 
using HeroesAPI.Repositories; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mongoDbSettings = builder.Configuration.GetSection("MongoDBSettings").Get<MongoDBSettings>();
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(mongoDbSettings.ConnectionString));

builder.Services.AddScoped<IHeroRepository, HeroRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
