using ShipMonitor.Models.Ships;

namespace ShipMonitor.Business;

public interface IShipBusiness
{
    Task<Guid> CreateAsync(ShipEditModel model);
    Task<ShipInfoModel> GetAsync(Guid shipId);
    Task UpdateAsync(Guid id, ShipEditModel model);
    Task DeleteAsync(Guid id);
    Task<Guid> AddState(Guid id, string state);
}
