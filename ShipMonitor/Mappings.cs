using AutoMapper;
using ShipMonitor.Database.Entities;
using ShipMonitor.Models.Ships;

namespace ShipMonitor;

public class Mappings : Profile
{
    public Mappings()
    {
        CreateMap<ShipEditModel, Ship>();
        CreateMap<Ship, ShipInfoModel>();
    }
}
