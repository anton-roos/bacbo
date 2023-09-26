using BacBo.Models;

namespace BacBo.Services;

public class SimulationService : ISimulationService
{
    public SimulationService()
    {
        
    }

    public List<BacBoResult> Simulate(double bankroll)
    {
        Random random = new Random();
        int bet = 10;
        List<BacBoResult> list = new List<BacBoResult>();
        int i = 0;
        while (bankroll > 0)
        {
            var result = new BacBoResult();
            result.Id = i++;
            result.DrawDate = DateTime.Now;
            result.Balance = bankroll;
            result.PlayerFirstRoll = random.Next(1, 7);
            result.PlayerSecondRoll = random.Next(1, 7);
            result.BankerFirstRoll = random.Next(1, 7);
            result.BankerSecondRoll = random.Next(1, 7);

            result.PlayerScore = result.PlayerFirstRoll + result.PlayerSecondRoll;
            result.BankerScore = result.BankerFirstRoll + result.BankerSecondRoll;

            if (result.PlayerScore == result.BankerScore) 
            {
                bankroll = bankroll - bet;
                bet = bet * 2;
                result.Balance = bankroll;
                list.Add(result);
            }
            if (result.PlayerScore > result.BankerScore)
            {
                bankroll += bet;
                bet = 10;
                result.Balance = bankroll;
                list.Add(result);
            }
            if (result.BankerScore > result.PlayerScore)
            {
                bankroll = bankroll - bet;
                bet *= 2;
                result.Balance = bankroll;
                list.Add(result);
            }
        }
        return list;
    }
}
