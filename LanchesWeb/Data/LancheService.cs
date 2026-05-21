using LanchesLibrary.Data;

namespace LanchesWeb.Data;

public class LancheService(IHttpClientFactory httpClientFactory) : ILancheService
{
    public async Task<List<Lanche>> LoadLanchesAsync()
    {
        HttpClient client = httpClientFactory.CreateClient();

        try
        {
            var lanches = await client.GetFromJsonAsync<IEnumerable<Lanche>>(
                "https://lanches-s5xm.onrender.com/lanches.json");

            return lanches!.ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}