using System.Text.Json.Serialization;

namespace ShipMonitor.Integrations;

/// <summary>
/// {"MMSI":244750034,"TIME":"1625826523","LONGITUDE":3022815,"LATITUDE":31476144,"COG":3600,"SOG":0,"HEADING":511,"ROT":128,"NAVSTAT":8,"IMO":0,"NAME":"CHATEAUROUX","CALLSIGN":"PH7002","TYPE":69,"A":24,"B":6,"C":0,"D":6,"DRAUGHT":12,"DEST":"","ETA":1596}
/// </summary>
public class VesselInfo
{
    [JsonPropertyName("MMSI")]
    public int Mmsi { get; set; }

    [JsonPropertyName("TIME")]
    public DateTime Time { get; set; }

    [JsonPropertyName("LATITUDE")]
    public float Latitude { get; set; }

    [JsonPropertyName("LONGITUDE")]
    public float Longitude { get; set; }

    [JsonPropertyName("COG")]
    public float Cog { get; set; }

    [JsonPropertyName("SOG")]
    public float Sog { get; set; }

    [JsonPropertyName("HEADING")]
    public int Heading { get; set; }

    [JsonPropertyName("ROT")]
    public int Rot { get; set; }

    [JsonPropertyName("NAVSTAT")]
    public float NavStat { get; set; }

    [JsonPropertyName("IMO")]
    public int Imo { get; set; }

    [JsonPropertyName("NAME")]
    public string Name { get; set; }

    [JsonPropertyName("CALLSIGN")]
    public string CallSign { get; set; }

    [JsonPropertyName("TYPE")]
    public int Type { get; set; }

    [JsonPropertyName("A")]
    public int A { get; set; }

    [JsonPropertyName("B")]
    public int B { get; set; }

    [JsonPropertyName("C")]
    public int C { get; set; }

    [JsonPropertyName("D")]
    public int D { get; set; }

    [JsonPropertyName("DRAUGHT")]
    public int Draught { get; set; }

    [JsonPropertyName("Dest")]
    public string Dest { get; set; }

    [JsonPropertyName("ETA")]
    public string Eta { get; set; }
}
