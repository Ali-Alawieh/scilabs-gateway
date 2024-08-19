using System.ComponentModel.DataAnnotations.Schema;

namespace Scilabs.Gateway.Core.Entities;

public class BucketDiPHouse
{
    [Column("entityid")] public string? EntityId { get; set; }

    [Column("timeindex")] public DateTime TimeIndex { get; set; }

    [Column("batteryvoltage")] public double? Batteryvoltage { get; set; }

    [Column("batterycurrent")]
    public double? BatteryCurrent { get; set; }

    [Column("batterypower")]
    public double? BatteryPower { get; set; }
    
    [Column("solarvoltage")]
    public double? SolarVoltage { get; set; }

    [Column("solarcurrent")]
    public double? SolarCurrent { get; set; }

    [Column("solarpower")]
    public double? SolarPower { get; set; }
    
    [Column("loadvoltage")]
    public double? LoadVoltage { get; set; }

    [Column("loadcurrent")]
    public double? LoadCurrent { get; set; }

    [Column("loadpower")]
    public double? LoadPower { get; set; }

    [Column("exchangevoltage")]
    public double? ExchangeVoltage { get; set; }
    
    [Column("exchangecurrent")]
    public double? ExchangeCurrent { get; set; }

    [Column("exchangepower")]
    public double? ExchangePower { get; set; }

    [Column("currentexchangemode")]
    public double? CurrentExchangeMode { get; set; }
}