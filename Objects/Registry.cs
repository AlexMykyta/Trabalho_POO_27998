namespace Utilities
{
    public static class Registry
    {
        // Método genérico para carregar dados de ficheiro
        public static List<T> LoadFromFile<T>(string filePath, Func<string, T> parseLine)
        {
            var items = new List<T>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"O ficheiro não foi encontrado: {filePath}");
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    try
                    {
                        // Parse da linha usando o método fornecido
                        var item = parseLine(line);
                        items.Add(item);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao processar a linha: {line}. Erro: {ex.Message}");
                    }
                }
            }

            return items;
        }
    }

}
