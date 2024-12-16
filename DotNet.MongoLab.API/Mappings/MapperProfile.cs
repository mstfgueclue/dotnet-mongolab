using AutoMapper;
using DotNet.MongoLab.API.DTOs.Vehicles.Abstract;
using DotNet.MongoLab.API.DTOs.Vehicles.Cars;
using DotNet.MongoLab.API.DTOs.Vehicles.Trucks;
using DotNet.MongoLab.Data.Documents.Vehicles.Abstract;
using DotNet.MongoLab.Data.Documents.Vehicles.Cars;
using DotNet.MongoLab.Data.Documents.Vehicles.Trucks;

namespace DotNet.MongoLab.API.Mappings;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        // Polymorphic mappings
        CreateMap<Vehicle, VehicleDto>()
            .IncludeAllDerived()
            .ReverseMap()
            .IncludeAllDerived()
            .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore Id for POST requests

        // Specific mappings for derived types
        CreateMap<Sedan, SedanDto>().ReverseMap();
        CreateMap<SUV, SUVDto>().ReverseMap();
        CreateMap<PickupTruck, PickupTruckDto>().ReverseMap();
        CreateMap<BoxTruck, BoxTruckDto>().ReverseMap();
    }
}
