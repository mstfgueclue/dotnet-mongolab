using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Conventions;

namespace DotNet.MongoLab.Data.Extensions;

public static class IServiceCollectionExtensions
{
    public static void AddDataLayer(this IServiceCollection services)
    {
        services.AddMongoDB();
    }

    private static void AddMongoDB(this IServiceCollection services)
    {
        services.AddSingleton<MongoDbContext>();

        var camelCaseConvention = new ConventionPack
        {
            new CamelCaseElementNameConvention()
        };
        ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);
    }
}
