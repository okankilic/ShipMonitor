using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShipMonitor.Database;
using ShipMonitor.Database.Entities;
using ShipMonitor.Models.Ships;

namespace ShipMonitor.Business;

public class ShipBusiness : IShipBusiness
{
    readonly ShipMonitorDbContext _dbContext;
    readonly IMapper _mapper;

    public ShipBusiness(
        ShipMonitorDbContext dbContext,
        IMapper mapper)
    {
        _dbContext = dbContext
            ?? throw new ArgumentNullException(nameof(dbContext));

        _mapper = mapper
            ?? throw new ArgumentNullException(nameof(mapper));
    }

    public Task<Guid> AddState(Guid id, string state)
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> CreateAsync(ShipEditModel model)
    {
        Ship ship = _mapper.Map<Ship>(model);

        ship.Id = Guid.NewGuid();

        _dbContext.Ships.Add(ship);

        await _dbContext.SaveChangesAsync();

        return ship.Id;
    }

    public async Task DeleteAsync(Guid id)
    {
        var ship = await _dbContext.Ships
            .SingleOrDefaultAsync(s => s.Id == id)
            ?? throw new Exception($"Ship not found.");

        _dbContext.Ships.Remove(ship);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<ShipInfoModel> GetAsync(Guid id)
    {
        var ship = await _dbContext.Ships
            .AsNoTracking()
            .SingleOrDefaultAsync(s => s.Id == id)
            ?? throw new Exception($"Ship not found.");

        return _mapper.Map<ShipInfoModel>(ship);
    }

    public async Task UpdateAsync(Guid id, ShipEditModel model)
    {
        var ship = await _dbContext.Ships
            .SingleOrDefaultAsync(s => s.Id == id)
            ?? throw new Exception($"Ship not found.");

        _mapper.Map(ship, model);

        _dbContext.Ships.Update(ship);

        await _dbContext.SaveChangesAsync();
    }
}
