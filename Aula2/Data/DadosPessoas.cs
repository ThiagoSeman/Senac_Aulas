using Aula1.Model;
using System.Text.Json;

namespace Aula2.Data
{
    public class DadosPessoas
    {
        public async Task<List<Pessoa>> ReadJsonAsync(string jsonFilePath)
        {
            try
            {
                
                string jsonString = File.ReadAllText(jsonFilePath);
                           
                    List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString)!;
                    return pessoas;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                return null;
            }
        }
    }
}
