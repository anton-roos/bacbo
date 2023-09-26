using BacBo.Database;
using BacBo.Models;

namespace BacBo.Services;

public class BacBoService : IBacBoService
{
    private BacBoContextFactory _contextFactory;
    private BacBoContext _context;
    
    public BacBoService(BacBoContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
        _context = _contextFactory.CreateDbContext();
    }

    public List<BacBoResult> GetAllBacBoResults()
    {
        return _context.BacBoResults.ToList();
    }

    public async Task<BacBoResult> GetBacBoResult(int id)
    {
        return await _context.FindAsync<BacBoResult>(id) ?? new BacBoResult { Source = "Doesn't Exist"};
    }

    public bool StoreBacBoResult(BacBoResult bacBoResult)
    {
        _context.Add(bacBoResult);
        _context.SaveChanges();
        return true;
    }
}
