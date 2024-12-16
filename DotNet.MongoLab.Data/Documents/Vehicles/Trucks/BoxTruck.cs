using DotNet.MongoLab.Data.Documents.Vehicles.Trucks.Abstract;

namespace DotNet.MongoLab.Data.Documents.Vehicles.Trucks;

public class BoxTruck : Truck
{
    public double CargoVolume { get; set; } // in cubic meters
}
