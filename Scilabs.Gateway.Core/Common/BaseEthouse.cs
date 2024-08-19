using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scilabs.Gateway.Core.Common;

public class BaseEthouse
{
    [Key] [Column("entity_id")] public string? EntityId { get; set; }

    [Column("time_index")] public DateTime TimeIndex { get; set; }

}