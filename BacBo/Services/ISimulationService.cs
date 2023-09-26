using BacBo.Models;

namespace BacBo.Services;

public interface ISimulationService
{
    List<BacBoResult> Simulate(double bankroll);
}
