using TargetChallenges.Data.Mappings;
using TargetChallenges.Infrastructure.Utils;

namespace TargetChallenges.Challenges;

// Desafio 3
public class Revenue
{
    // Props
    public string Path { get; set; }
    public List<DailyRevenue>? Data { get; set; }
    // Lista com os dias que possuem faturamento
    private List<DailyRevenue> BillingDays => Data?.Where(d => d.Value > 0).ToList() ?? [];

    // Método construtor
    // Recebe o path do JSON e faz a desserialização
    public Revenue()
    {
        Path = "Data/Json/dailyRevenue.json";
        Data = JsonLoader.LoadFromFile<DailyRevenue>(Path);
    }

    // Faz a MÉDIA de faturamento do mês
    public double AverageRevenue()
    {
        return BillingDays.Count != 0 ? BillingDays.Average(d => d.Value) : 0.0;
    }

    // Busca o MAIOR valor de faturamento do mês
    public double HigherRevenue()
    {
        return BillingDays.Count != 0 ? BillingDays.Max(d => d.Value) : 0.0;
    }

    // Busca o MENOR valor de faturamento do mês
    public double LowerRevenue()
    {
        return BillingDays.Count != 0 ? BillingDays.Min(d => d.Value) : 0.0;
    }

    // Calcula a quantidade de DIAS acima da média
    public int CountAboveAverage()
    {
        if (BillingDays.Count == 0)
            return 0;

        // Calcula a média e retorna apenas a quantidade de dias acima desse valor
        double average = BillingDays.Average(d => d.Value);
        return BillingDays.Count(d => d.Value > average);
    }

    // Realiza os cálculos e converte para String com currency (R$)
    public virtual void CalculateResults()
    {
        string average = AverageRevenue().ToString("C");
        string higher = HigherRevenue().ToString("C");
        string lower = LowerRevenue().ToString("C");
        int days = CountAboveAverage();
        // Chama a função ShowResults() passando os resultados como parâmetro
        ShowResults(higher, lower, average, days);
    }

    // Imprime os resultados na interface para o usuário
    public static void ShowResults(string average, string higher, string lower, int days)
    {
        Console.WriteLine($"MÉDIA de faturamento mensal: {average}\n");
        Console.WriteLine($"MAIOR valor do mês: {higher}");
        Console.WriteLine($"MENOR valor do mês: {lower}");
        Console.WriteLine($"DIAS acima da MÉDIA: {days}\n");
    }

}
