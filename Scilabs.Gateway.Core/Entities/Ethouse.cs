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

    [Column("gridpower")]
    public double? Gridpower { get; set; }

    [Column("photovoltaicpower")]
    public double? Photovoltaicpower { get; set; }

    [Column("activepower")]
    public double? Activepower { get; set; }

    [Column("stateofcharge")]
    public double? Stateofcharge { get; set; }

    [Column("compressorpower")]
    public double? Compressorpower { get; set; }

    [Column("heatoutput")]
    public double? Heatoutput { get; set; }

    [Column("heatoutputheating")]
    public double? Heatoutputheating { get; set; }

    [Column("heatoutputhotwater")]
    public double? Heatoutputhotwater { get; set; }

    [Column("coefficientofperformance")]
    public double? Coefficientofperformance { get; set; }

    [Column("condensationpressure")]
    public double? Condensationpressure { get; set; }

    [Column("expansionvalveopeningdegree")]
    public double? Expansionvalveopeningdegree { get; set; }

    [Column("evaporationpressure")]
    public double? Evaporationpressure { get; set; }

    [Column("suctiongastemperature")]
    public double? Suctiongastemperature { get; set; }

    [Column("floorheatingreturnflowsettemperature")]
    public double? Floorheatingreturnflowsettemperature { get; set; }

    [Column("hotwatersettemperature")]
    public double? Hotwatersettemperature { get; set; }

    [Column("heatingpumppower")]
    public double? Heatingpumppower { get; set; }

    [Column("floorheatingflowtemperature")]
    public double? Floorheatingflowtemperature { get; set; }

    [Column("floorheatingreturnflowtemperature")]
    public double? Floorheatingreturnflowtemperature { get; set; }

    [Column("sourcepumppower")]
    public double? Sourcepumppower { get; set; }

    [Column("sourceouttemperature")]
    public double? Sourceouttemperature { get; set; }

    [Column("sourceintemperature")]
    public double? Sourceintemperature { get; set; }

    [Column("compressorstartcount")]
    public double? Compressorstartcount { get; set; }

    [Column("hotwateractive")]
    public bool? Hotwateractive { get; set; }

    [Column("hotwatertemperature")]
    public double? Hotwatertemperature { get; set; }

    [Column("electricalheatingpower")]
    public double? Electricalheatingpower { get; set; }

    [Column("electricalheatingactive")]
    public bool? Electricalheatingactive { get; set; }

    [Column("supplyairtemperature")]
    public double? Supplyairtemperature { get; set; }

    [Column("exhaustairtemperature")]
    public double? Exhaustairtemperature { get; set; }

    [Column("freshairtemperature")]
    public double? Freshairtemperature { get; set; }

    [Column("returnairtemperature")]
    public double? Returnairtemperature { get; set; }

    [Column("ventilationpower")]
    public double? Ventilationpower { get; set; }

    [Column("outdoortemperature")]
    public double? Outdoortemperature { get; set; }

    [Column("b_6")]
    public long? B6 { get; set; }

    [Column("r_temp_vl")]
    public string? RTempVl { get; set; }

    [Column("r_temp_qaus_epb")]
    public string? RTempQausEpb { get; set; }

    [Column("r_p_vent")]
    public string? RPVent { get; set; }

    [Column("r_hm_tempb")]
    public string? RHmTempb { get; set; }

    [Column("di_p_7")]
    public long? DiP7 { get; set; }

    [Column("di_p_6")]
    public string? DiP6 { get; set; }

    [Column("w_5052_do_bm_e1")]
    public string? W5052DoBmE1 { get; set; }

    [Column("r_p_pquelle")]
    public string? RPPquelle { get; set; }

    [Column("r_temp_fol")]
    public string? RTempFol { get; set; }

    [Column("r_temp_rlsoll")]
    public string? RTempRlsoll { get; set; }

    [Column("r_hm_sum")]
    public string? RHmSum { get; set; }

    [Column("di_p_pheizung")]
    public string? DiPPheizung { get; set; }

    [Column("i_2")]
    public long? I2 { get; set; }

    [Column("r_hm_tempdiff")]
    public string? RHmTempdiff { get; set; }

    [Column("di_p_bat_ac")]
    public long? DiPBatAc { get; set; }

    [Column("di_p_batt_dc")]
    public long? DiPBattDc { get; set; }

    [Column("di_p_solar")]
    public long? DiPSolar { get; set; }

    [Column("di_p_netz")]
    public long? DiPNetz { get; set; }

    /*[Column("di_p_haus")]
    public long? DiPHaus { get; set; }*/

    [Column("di_p_tww_ecopac")]
    public string? DiPTwwEcopac { get; set; }

    [Column("r_p_pheizung")]
    public string? RPPheizung { get; set; }

    [Column("di_p_netz2")]
    public long? DiPNetz2 { get; set; }

    [Column("i_batt_cyc")]
    public long? IBattCyc { get; set; }

    [Column("r_prcond")]
    public string? RPrcond { get; set; }

    [Column("r_tempsucg")]
    public string? RTempsucg { get; set; }

    [Column("r_temp_zul")]
    public string? RTempZul { get; set; }

    [Column("b_gsiv2")]
    public long? BGsiv2 { get; set; }

    [Column("r_temp_aussen24h")]
    public string? RTempAussen24h { get; set; }

    [Column("di_p_comp")]
    public long? DiPComp { get; set; }

    [Column("r_temp_raum")]
    public string? RTempRaum { get; set; }

    [Column("di_p_batt_soc")]
    public long? DiPBattSoc { get; set; }

    [Column("di_ptherm_ww")]
    public long? DiPthermWw { get; set; }

    [Column("w_5055_do_bm_e1")]
    public string? W5055DoBmE1 { get; set; }

    [Column("r_temp_qein")]
    public string? RTempQein { get; set; }

    [Column("r_prcteev")]
    public string? RPrcteev { get; set; }

    [Column("i_housenum")]
    public string? IHousenum { get; set; }

    [Column("r_cop")]
    public string? RCop { get; set; }

    [Column("b_5")]
    public long? B5 { get; set; }

    [Column("r_hm_wtherm")]
    public string? RHmWtherm { get; set; }

    [Column("r_temp_gsigia")]
    public string? RTempGsigia { get; set; }

    [Column("w_5053_error_e1")]
    public string? W5053ErrorE1 { get; set; }

    [Column("b_extwe")]
    public long? BExtwe { get; set; }

    [Column("di_p_eheiz")]
    public long? DiPEheiz { get; set; }

    [Column("i_count_start_comp")]
    public long? ICountStartComp { get; set; }

    [Column("r_temp_aul")]
    public string? RTempAul { get; set; }

    [Column("r_temp_gsisa_ret")]
    public string? RTempGsisaRet { get; set; }

    [Column("di_ptherm_hzg")]
    public long? DiPthermHzg { get; set; }

    [Column("r_temp_aussen")]
    public double? RTempAussen { get; set; }

    [Column("di_p_batt")]
    public long? DiPBatt { get; set; }

    [Column("di_p_pquelle")]
    public string? DiPPquelle { get; set; }

    [Column("b_v_ww")]
    public long? BVWw { get; set; }

    [Column("di_p_booster")]
    public string? DiPBooster { get; set; }

    [Column("r_temp_qaus")]
    public string? RTempQaus { get; set; }

    [Column("r_temp_abl")]
    public string? RTempAbl { get; set; }

    [Column("di_p_batt_pump")]
    public long? DiPBattPump { get; set; }

    [Column("r_tempout1")]
    public string? RTempout1 { get; set; }

    [Column("di_p_w2")]
    public long? DiPW2 { get; set; }

    [Column("r_hm_flow")]
    public string? RHmFlow { get; set; }

    [Column("di_ptherm_wp")]
    public long? DiPthermWp { get; set; }

    [Column("r_p_tww_ecopack")]
    public string? RPTwwEcopack { get; set; }

    [Column("r_temp_qein_epb")]
    public string? RTempQeinEpb { get; set; }

    [Column("b_gsiv1")]
    public long? BGsiv1 { get; set; }

    [Column("di_p_5")]
    public long? DiP5 { get; set; }

    [Column("r_temp_gsigia_ret")]
    public string? RTempGsigiaRet { get; set; }

    [Column("r_temp_rl")]
    public string? RTempRl { get; set; }

    [Column("di_p_8")]
    public long? DiP8 { get; set; }

    [Column("r_temp_wwist")]
    public string? RTempWwist { get; set; }

    [Column("r_prevap")]
    public string? RPrevap { get; set; }

    [Column("i_3")]
    public long? I3 { get; set; }

    [Column("r_prccp")]
    public string? RPrccp { get; set; }

    [Column("w_5054_inte1")]
    public string? W5054Inte1 { get; set; }

    [Column("r_hm_tempa")]
    public string? RHmTempa { get; set; }

    [Column("r_temp_gsisa")]
    public string? RTempGsisa { get; set; }

    [Column("di_p_wp")]
    public long? DiPWp { get; set; }

    [Column("r_prchsp")]
    public string? RPrchsp { get; set; }

    [Column("r_p_booster")]
    public string? RPBooster { get; set; }

    [Column("di_p_vent")]
    public string? DiPVent { get; set; }

    [Column("r_temp_wwsoll")]
    public string? RTempWwsoll { get; set; }

    [Column("is_imported")]
    public bool IsImported { get; set; }
}