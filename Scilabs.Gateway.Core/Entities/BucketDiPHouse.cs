using System.ComponentModel.DataAnnotations.Schema;

namespace Scilabs.Gateway.Core.Entities;

public class BucketDiPHouse
{
    [Column("entityid")] public string? EntityId { get; set; }

    [Column("timeindex")] public DateTime TimeIndex { get; set; }

    [Column("batteryvoltage")] 
    public double? Batteryvoltage { get; set; }

    [Column("batterycurrent")]
    public double? BatteryCurrent { get; set; }

    [Column("batterypower")]
    public double? BatteryPower { get; set; }
    
    [Column("batterychargelevel")]
    public double? BatterySoc { get; set; }
    
    [Column("batterycapacity")]
    public double? BatteryCap { get; set; }
    
    [Column("solarmodulevoltage")]
    public double? SolarVoltage { get; set; }
    


    [Column("solarmodulecurrent")]
    public double? SolarCurrent { get; set; }

    [Column("solarmodulepower")]
    public double? SolarPower { get; set; }
    
    [Column("loadvoltage")]
    public double? LoadVoltage { get; set; }

    [Column("loadcurrent")]
    public double? LoadCurrent { get; set; }

    [Column("loadpower")]
    public double? LoadPower { get; set; }

    [Column("energyexchangevoltage")]
    public double? ExchangeVoltage { get; set; }
    
    [Column("energyexchangecurrent")]
    public double? ExchangeCurrent { get; set; }

    [Column("energyexchangepower")]
    public double? ExchangePower { get; set; }

    [Column("energyexchangemode")]
    public double? CurrentExchangeMode { get; set; }
}