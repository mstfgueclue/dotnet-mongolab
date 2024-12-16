using DotNet.MongoLab.API.DTOs.Vehicles.Cars.Abstract;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Cars;

public record SUVDto : CarDto
{
    public bool IsFourWheelDrive { get; set; }
}
