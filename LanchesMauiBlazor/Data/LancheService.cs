using LanchesLibrary.Data;

namespace LanchesMauiBlazor.Data;

public class LancheService : ILancheService
{
    public async Task<List<Lanche>> LoadLanchesAsync()
    {
        await Task.Delay(1_000);

        Lanche[] lanches =
        [
            new() { Name = "Cheese Burger", Description = "Pão e Hamburger tradicional com queijo" },
            new() { Name = "Cheese Salada", Description = "Pão e Hamburger tradicional com queijo e alface" },
            new() { Name = "Cheese Salada Egg", Description = "Pão e Hamburger tradicional com queijo e alface e ovo" },
            new() { Name = "Misto Quente", Description = "Pão de forma, presunto e queijo" },
            new() { Name = "Bauru", Description = "Pão de forma, presunto, queijo, tomate e queijo" }
        ];

        return lanches.ToList();
    }
}