namespace LanchesLibrary.Data;

public interface ILancheService
{
    Task<IEnumerable<Lanche>>? LoadLanchesAsync();
}