using DotNet.MongoLab.API.DTOs.Vehicles.Cars;
using DotNet.MongoLab.API.DTOs.Vehicles.Trucks;
using DotNet.MongoLab.Data.Documents.Vehicles.Cars;
using DotNet.MongoLab.Data.Documents.Vehicles.Trucks;
using System.Text.Json.Serialization;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Abstract;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$__t")]
[JsonDerivedType(typeof(SedanDto), nameof(Sedan))]
[JsonDerivedType(typeof(SUVDto), nameof(SUV))]
[JsonDerivedType(typeof(BoxTruckDto), nameof(BoxTruck))]
[JsonDerivedType(typeof(PickupTruckDto), nameof(PickupTruck))]
public abstract record VehicleDto
{
    public string? Id { get; set; }
    public required string Manufacturer { get; set; }
    public required int Year { get; set; }
}
