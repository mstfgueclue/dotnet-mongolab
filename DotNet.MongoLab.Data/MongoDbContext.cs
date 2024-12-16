using DotNet.MongoLab.Data.Documents.Vehicles.Abstract;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DotNet.MongoLab.Data;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;
    public IMongoCollection<Vehicle> Vehicles => _database.GetCollection<Vehicle>("vehicles");

    public MongoDbContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MongoDb")
            ?? throw new InvalidOperationException("MongoDb string is not configured.");

        var mongoClient = new MongoClient(connectionString);
        _database = mongoClient.GetDatabase(configuration["MongoDbSettings:DatabaseName"]);
    }
}
