using DotNet.MongoLab.API.DTOs.Vehicles.Trucks.Abstract;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Trucks;

public record PickupTruckDto : TruckDto
{
    public bool HasExtendedCab { get; set; }
}
