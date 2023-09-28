namespace ShipMonitor.Database.Entities;

public class ShipState
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ShipId { get; set; } = default;

    //  relations
    public virtual Ship? Ship { get; set; }
}
