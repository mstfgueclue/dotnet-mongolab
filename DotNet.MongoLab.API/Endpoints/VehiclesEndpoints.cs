using AutoMapper;
using DotNet.MongoLab.API.DTOs.Vehicles.Abstract;
using DotNet.MongoLab.Data;
using DotNet.MongoLab.Data.Documents.Vehicles.Abstract;
using MongoDB.Driver;

namespace DotNet.MongoLab.API.Endpoints;

public static class VehiclesEndpoints
{
    public static void MapVehicleEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/vehicles", async (MongoDbContext dbContext, IMapper mapper) =>
        {
            var vehicles = await dbContext.Vehicles.Find(_ => true).ToListAsync();
            var vehicleDtos = mapper.Map<IEnumerable<VehicleDto>>(vehicles);

            return Results.Json(vehicleDtos);
        });

        app.MapGet("/vehicles/{id}", async (MongoDbContext dbContext, IMapper mapper, string id) =>
        {
            var vehicle = await dbContext.Vehicles.Find(v => v.Id == id).FirstOrDefaultAsync();
            if (vehicle is null)
            {
                return Results.NotFound();
            }

            var vehicleDto = mapper.Map<VehicleDto>(vehicle);

            return Results.Json(vehicle);
        });

        app.MapPost("/vehicles", async (MongoDbContext dbContext, IMapper mapper, VehicleDto vehicleDto) =>
        {
            var vehicle = mapper.Map<Vehicle>(vehicleDto);
            await dbContext.Vehicles.InsertOneAsync(vehicle);

            return Results.Created($"/vehicles/{vehicle.Id}", vehicle);
        });
    }
}
