using System.Text.Json.Serialization;

namespace TargetChallenges.Data.Mappings;

// Mapping do JSON com o faturamento mensal (De/Para)
public class DailyRevenue
{
    [JsonPropertyName("dia")]
    public int Day { get; set; }

    [JsonPropertyName("valor")]
    public double Value { get; set; }
}
