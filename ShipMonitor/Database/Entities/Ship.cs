namespace ShipMonitor.Database.Entities;

public class Ship
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Imo { get; set; } = string.Empty;
    public string ShipName { get; set; } = string.Empty;

    //  relations
    public virtual ICollection<ShipState>? States { get; set; }
}
