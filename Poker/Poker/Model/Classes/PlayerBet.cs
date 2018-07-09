using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Model.Interfaces;

namespace Poker.Model.Classes
{
    public class PlayerBet: IPlayerBet
    {

        public int BetValue { get; set; }
        public IPlayer Owner { get; }
        public int OrderCount { get; set; }
        public int ResultCount { get; set; }
        public int ResultPoint { get; set; }

        public int Calculate(int rate)
        {
            if (OrderCount == ResultCount)
                return OrderCount * rate * BetValue;
            if (OrderCount > ResultCount)
                return (OrderCount - ResultCount) * rate * BetValue * -1;

            return ResultCount * rate;
        }

        public RoundKind Kind { get; private set; }
    }
}
