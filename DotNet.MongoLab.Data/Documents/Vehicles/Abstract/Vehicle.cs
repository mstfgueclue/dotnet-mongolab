using DotNet.MongoLab.Data.Documents.Vehicles.Cars.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Trucks.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotNet.MongoLab.Data.Documents.Vehicles.Abstract;

[BsonKnownTypes(typeof(Car))]
[BsonKnownTypes(typeof(Truck))]
public abstract class Vehicle
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
    public required string Manufacturer { get; set; }
    public required int Year { get; set; }
}
