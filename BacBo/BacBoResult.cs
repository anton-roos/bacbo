using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacBo
{
    public class BacBoResult
    {
        public DateTime DrawDate { get; set; }
        public int PlayerFirstRoll { get; set; }
        public int BankerFirstRoll { get; set; }
        public int PlayerSecondRoll { get; set; }
        public int BankerSecondRoll { get; set; }
        public int PlayerScore { get; set; }
        public int BankerScore { get; set; }
        public bool PlayerWins { get; set; }
        public bool BankerWins { get; set; }
        public bool Tie { get; set; }
        public string Source { get; set; }
    }
}
