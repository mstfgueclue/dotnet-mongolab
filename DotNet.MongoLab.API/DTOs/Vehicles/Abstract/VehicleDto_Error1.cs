using DotNet.MongoLab.API.DTOs.Vehicles.Cars.Abstract;
using DotNet.MongoLab.API.DTOs.Vehicles.Trucks.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Cars.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Trucks.Abstract;
using System.Text.Json.Serialization;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Abstract;

/// <summary>
/// The error message when abstract classes are used in the JsonPolymorphic attribute is as follows:
/// System.InvalidOperationException: Specified type 'DotNet.MongoLab.API.DTOs.Vehicles.Cars.Abstract.CarDto' 
/// is not a supported derived type for the polymorphic type 'DotNet.MongoLab.API.DTOs.Vehicles.Abstract.VehicleDto'. 
/// Derived types must be assignable to the base type, must not be generic and cannot be abstract classes or interfaces 
/// unless 'JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor' is specified.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$__t")]
[JsonDerivedType(typeof(CarDto), nameof(Car))]
[JsonDerivedType(typeof(TruckDto), nameof(Truck))]
public abstract record VehicleDto_Error1
{
    public required string Id { get; set; }
    public required string Manufacturer { get; set; }
    public required int Year { get; set; }
}
