using DotNet.MongoLab.API.DTOs.Vehicles.Cars.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Cars;
using System.Text.Json.Serialization;

namespace DotNet.MongoLab.API.DTOs.Vehicles.Cars;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$__t")]
[JsonDerivedType(typeof(SedanDto), nameof(Sedan))]
public record SedanDto : CarDto
{
    public bool HasSunroof { get; set; }
}
