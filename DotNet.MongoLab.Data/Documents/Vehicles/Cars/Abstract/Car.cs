using DotNet.MongoLab.Data.Documents.Vehicles.Abstract;
using MongoDB.Bson.Serialization.Attributes;

namespace DotNet.MongoLab.Data.Documents.Vehicles.Cars.Abstract;

[BsonKnownTypes(typeof(Sedan))]
[BsonKnownTypes(typeof(SUV))]
public abstract class Car : Vehicle
{
    public required int NumberOfDoors { get; set; }
}
