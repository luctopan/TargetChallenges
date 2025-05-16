namespace TargetChallenges.Challenges;

// Desafio 1
public class While
{
    private readonly int Index = 13; // Valor do índice, apenas para leitura

    public int Loop()
    {
        int k = 0;
        int sum = 0;

        while (k < Index) // Enquanto K for menor que o índice, faça:
        {
            k++; // k = k + 1
            sum += k; // soma = soma + k            
        }

        return sum;
    }
}
