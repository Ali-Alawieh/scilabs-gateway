using System.ComponentModel.DataAnnotations.Schema;

namespace Scilabs.Gateway.Core.Entities;

public class BucketDiPHouse
{
    [Column("entityid")] public string? EntityId { get; set; }

    [Column("timeindex")] public DateTime TimeIndex { get; set; }

    [Column("di_p_haus")] public long? di_p_haus { get; set; }

    [Column("di_p_batt_soc")] public long? di_p_batt_soc { get; set; }

    [Column("di_p_solar")] public long? di_p_solar { get; set; }

    [Column("di_p_netz")] public long? di_p_netz { get; set; }

    [Column("di_p_wp")] public long? di_p_wp { get; set; }
}