using System.Text;

namespace TargetChallenges.Challenges;

// Desafio 5
public class Reverser
{
    public static string Reverse(string text)
    {
        // Se o valor de text for nulo, retorna a mensagem abaixo
        if (text == null)
            return "String inválida.";

        // Cria um novo objeto do tipo StringBuilder
        StringBuilder newString = new();

        // Faz a iteração pelo text, começando da última posição
        for (int i = text.Length - 1; i >= 0; i--)
            // Anexa o char na nova string
            newString.Append(text[i]);

        // retorna o objeto como String
        return newString.ToString();
    }
}
