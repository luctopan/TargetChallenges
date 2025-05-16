using TargetChallenges.Challenges;

namespace TargetChallenges.UI;

public class Menu
{
    public static void Show()
    {
        // Limpa a interface e imprime as opções para o usuário
        Console.Clear();
        WriteOptions();

        // Recebe a opção do usuário e captura possíveis erros de tipo
        try
        {
            short option = Convert.ToInt16(Console.ReadLine());
            HandleMenuOption(option);
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato inválido. Por favor, digite um número válido.");
            Thread.Sleep(1000);
            Show();
        }
    }

    public static void WriteOptions()
    {
        Console.WriteLine("Desafios Técnicos:");
        Console.WriteLine("=================");
        Console.WriteLine("Escolha o desafio:");
        Console.WriteLine("1. Do/While");
        Console.WriteLine("2. Fibonacci");
        Console.WriteLine("3. Faturamento mensal");
        Console.WriteLine("4. Faturamento estadual");
        Console.WriteLine("5. String Reverser");
        Console.WriteLine("\n0. SAIR");
        Console.Write("\nOpção: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1:
                Console.Clear();

                While whileChallenge = new();
                var result = whileChallenge.Loop();
                Console.WriteLine($"Resultado: {result}\n");

                WaitAndReturnToMenu();
                Show();
                break;
            case 2:
                Console.Clear();

                int number;

                while (true)
                {
                    Console.Write("Digite um número inteiro: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out number))
                        break;

                    Console.Clear();
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }

                bool isFibonacci = Fibonacci.VerifyFibonacci(number);
                Console.WriteLine($"\nO número pertence à sequência de Fibonacci? (True/False)\n{isFibonacci}\n");

                WaitAndReturnToMenu();
                Show();
                break;
            case 3:
                Console.Clear();

                Revenue revenueChallenge = new();
                revenueChallenge.CalculateResults();

                WaitAndReturnToMenu();
                Show();
                break;
            case 4:
                Console.Clear();

                Percentage percentageChallenge = new();
                percentageChallenge.CalculateResults();

                WaitAndReturnToMenu();
                Show();
                break;
            case 5:
                Console.Clear();

                Console.Write("Digite uma string para inverter: ");
                var text = Console.ReadLine() ?? string.Empty;
                string reverseText = Reverser.Reverse(text);
                Console.WriteLine($"String invertida: {reverseText}\n");

                WaitAndReturnToMenu();
                Show();
                break;
            case 0:
                Console.Clear();
                Console.WriteLine("Saindo...");
                WaitAndReturnToMenu();
                Environment.Exit(0);
                break;
            default:
                Show();
                break;
        }
    }

    public static void WaitAndReturnToMenu()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

}
