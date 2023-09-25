using BacBo.Models;

namespace BacBo.Services;

public interface IBacBoService
{
    public bool StoreBacBoResult(BacBoResult bacBoResult);
    public Task<BacBoResult> GetBacBoResult(int id);
    public List<BacBoResult> GetAllBacBoResults();
}
