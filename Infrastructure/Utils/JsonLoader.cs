using System.Text.Json;

namespace TargetChallenges.Infrastructure.Utils;

// Classe utilizada para carregar e desserializar o JSON
public static class JsonLoader
{
    public static List<T>? LoadFromFile<T>(string path)
    {
        // Verifica se o arquivo existe
        if (!File.Exists(path))
        {
            Console.WriteLine($"Arquivo não encontrado: {path}");
            return null;
        }

        string json = File.ReadAllText(path);

        // Tenta desserializar o arquivo e converter para uma lista genérica
        try
        {
            return JsonSerializer.Deserialize<List<T>>(json);
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Erro ao desserializar o JSON: {ex.Message}");
            return null;
        }
    }
}
