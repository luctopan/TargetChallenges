using TargetChallenges.Data.Mappings;
using TargetChallenges.Infrastructure.Utils;

namespace TargetChallenges.Challenges;

// Desafio 4
public class Percentage
{
    // Props
    public string Path { get; set; }
    public List<StateRevenue>? Data { get; set; }

    // Método construtor
    // Recebe o path do JSON e faz a desserialização
    public Percentage()
    {
        Path = "Data/Json/stateRevenue.json";
        Data = JsonLoader.LoadFromFile<StateRevenue>(Path);
    }

    // Realiza os cálculos
    public void CalculateResults()
    {
        // Se Data for nulo ou 0, apenas sai da função sem retorno
        if (Data == null || Data.Count == 0)
            return;

        // Realiza a soma do faturamento mensal (de todos os estados)
        double total = Data.Sum(d => d.Value);

        // Calcula o percentual de cada estado
        foreach (var data in Data)
            data.Percentage = data.Value / total * 100;

        // Chama a função ShowResults() passando o total como parâmetro
        ShowResults(total);

    }

    public void ShowResults(double total)
    {
        Console.WriteLine($"FATURAMENTO MENSAL: {total:C}\n");

        // Imprime o valor de cada estado e o seu percentual
        foreach (var data in Data!)
        {
            Console.WriteLine($"Estado: {data.State}");
            Console.WriteLine($"Participação: {data.Value:C}");
            Console.WriteLine($"Percentual: {data.Percentage:F2}%\n");
        }
    }

}