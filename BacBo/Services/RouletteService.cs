using BacBo.Database;
using BacBo.Models;

namespace BacBo.Services;

public class RouletteService : IRouletteService
{
    private BacBoContextFactory _contextFactory;
    
    private BacBoContext _context;
    
    public RouletteService(BacBoContext context, BacBoContextFactory contextFactory)
    {
        _context = context;
        _contextFactory = contextFactory;
    }

    public void SaveRouletteResult(RouletteResult result)
    {
        _context.RouletteResults.Add(result);
        _context.SaveChanges();
    }

    public List<RouletteResult> GetRouletteResults()
    {
        return _context.RouletteResults.ToList();
    }
}
