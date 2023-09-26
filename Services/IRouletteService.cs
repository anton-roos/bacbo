using BacBo.Models;

namespace BacBo.Services;

public interface IRouletteService
{
    public void SaveRouletteResult(RouletteResult result);
    public List<RouletteResult> GetRouletteResults();
}