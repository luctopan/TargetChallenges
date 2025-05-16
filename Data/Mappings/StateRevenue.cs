using System.Text.Json.Serialization;

namespace TargetChallenges.Data.Mappings;

// Mapping do JSON com o faturamento por estado (De/Para)
public class StateRevenue
{
    [JsonPropertyName("estado")]
    public string? State { get; set; }

    [JsonPropertyName("valor")]
    public double Value { get; set; }
    public double Percentage { get; set; }
}
