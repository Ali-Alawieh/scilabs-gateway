using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scilabs.Gateway.Core.Entities;

public class Ethouse
{
    [Key][Column("entity_id")]
    public string? EntityId { get; set; }

    [Column("entity_type")]
    public string? EntityType { get; set; }

    [Column("time_index")]
    public DateTime TimeIndex { get; set; }

    [Column("fiware_servicepath")]
    public string? FiwareServicepath { get; set; }

    [Column("__original_ngsi_entity__")]
    public string? OriginalNgsiEntity { get; set; }
    
    [Column("instanceid")]
    public string? InstanceId { get; set; }

    [Column("batteryvoltage")]
    public double? Batteryvoltage { get; set; }

    [Column("batterycurrent")]
    public double? BatteryCurrent { get; set; }

    [Column("batterypower")]
    public double? BatteryPower { get; set; }

    [Column("batterysoc")]
    public double? BatterySoc { get; set; }

    [Column("batterycap")]
    public double? BatteryCap { get; set; }

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