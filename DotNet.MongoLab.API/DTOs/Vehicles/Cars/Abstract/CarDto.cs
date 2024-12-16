using DotNet.MongoLab.API.DTOs.Vehicles.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Cars;
using System.Text.Json.Serialization;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Cars.Abstract;

[JsonDerivedType(typeof(SedanDto), nameof(Sedan))]
[JsonDerivedType(typeof(SUVDto), nameof(SUV))]
public abstract record CarDto : VehicleDto
{
    public int NumberOfDoors { get; set; }
}
