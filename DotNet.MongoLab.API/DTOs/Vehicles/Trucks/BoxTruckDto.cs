using DotNet.MongoLab.API.DTOs.Vehicles.Trucks.Abstract;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Trucks;

public record BoxTruckDto : TruckDto
{
    public double CargoVolume { get; set; } // in cubic meters
}
