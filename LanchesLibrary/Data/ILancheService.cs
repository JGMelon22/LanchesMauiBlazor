namespace LanchesLibrary.Data;

public interface ILancheService
{
    Task<List<Lanche>> LoadLanchesAsync();
}