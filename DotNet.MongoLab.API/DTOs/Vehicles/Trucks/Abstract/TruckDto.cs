using DotNet.MongoLab.API.DTOs.Vehicles.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Trucks;
using System.Text.Json.Serialization;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Trucks.Abstract;

[JsonDerivedType(typeof(PickupTruckDto), nameof(PickupTruck))]
[JsonDerivedType(typeof(BoxTruckDto), nameof(BoxTruck))]
public abstract record TruckDto : VehicleDto
{
    public double PayloadCapacity { get; set; } // in tons
}
