namespace Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseList;

public class EthouseVm
{
    public string? EntityId { get; set; }

    public DateTime TimeIndex { get; set; }

    public double? Batteryvoltage { get; set; }

    public double? BatteryCurrent { get; set; }

    public double? BatteryPower { get; set; }

    public double? SolarVoltage { get; set; }

    public double? SolarCurrent { get; set; }

    public double? SolarPower { get; set; }

    public double? LoadVoltage { get; set; }

    public double? LoadCurrent { get; set; }

    public double? LoadPower { get; set; }

    public double? ExchangeVoltage { get; set; }

    public double? ExchangeCurrent { get; set; }

    public double? ExchangePower { get; set; }

    public double? CurrentExchangeMode { get; set; }
}