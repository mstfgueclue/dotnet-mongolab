using DotNet.MongoLab.Data.Documents.Vehicles.Abstract;
using MongoDB.Bson.Serialization.Attributes;

namespace DotNet.MongoLab.Data.Documents.Vehicles.Trucks.Abstract;

[BsonKnownTypes(typeof(BoxTruck))]
[BsonKnownTypes(typeof(PickupTruck))]
public abstract class Truck : Vehicle
{
    public double PayloadCapacity { get; set; } // in tons
}
