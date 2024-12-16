using DotNet.MongoLab.API.Endpoints;
using DotNet.MongoLab.API.Mappings;
using DotNet.MongoLab.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDataLayer();
builder.Services.AddAutoMapper(typeof(MapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapVehicleEndpoints();

app.UseHttpsRedirection();
app.Run();
