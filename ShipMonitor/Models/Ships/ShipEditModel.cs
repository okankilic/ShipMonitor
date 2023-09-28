using System.ComponentModel.DataAnnotations;

namespace ShipMonitor.Models.Ships;

public class ShipEditModel
{
    [Required, MinLength(7), MaxLength(7)]
    public string Imo { get; set; } = string.Empty;
    [Required, MaxLength(100)]
    public string ShipName { get; set; } = string.Empty;
}
