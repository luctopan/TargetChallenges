namespace TargetChallenges.Challenges;

// Desafio 2
public class Fibonacci
{
    public static bool VerifyFibonacci(int numberUser)
    {
        // Inicializa os dois primeiros números da sequência
        int numberA = 0;
        int numberB = 1;

        // Realiza o loop enquanto o valor atual (numberA) for menor ou igual ao número informado pelo usuário
        while (numberA <= numberUser)
        {
            // Se o número informado for igual ao valor atual da sequência, ele pertence à sequência
            if (numberA == numberUser)
                return true;

            // Próximo número da sequência
            int next = numberA;

            // Atualiza os valores da sequência
            numberA = numberB;
            numberB = next + numberB;
        }

        // Se o loop terminar sem encontrar o número, ele não pertence à sequência
        return false;
    }

}
