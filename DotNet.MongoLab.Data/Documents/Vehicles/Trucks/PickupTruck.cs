using DotNet.MongoLab.Data.Documents.Vehicles.Trucks.Abstract;

namespace DotNet.MongoLab.Data.Documents.Vehicles.Trucks;

public class PickupTruck : Truck
{
    public bool HasExtendedCab { get; set; }
}
