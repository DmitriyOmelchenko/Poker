using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Model.Interfaces;

namespace Poker.Model.Classes.Rounds
{
    public class MiseryRound: BaseRound
    {
        public MiseryRound(int number) : base(number, 1, -10)
        {
        }

        public MiseryRound(int number, IPlayerBet[] bets) : base(number, 1, -10, bets)
        {
        }

        protected override int CalculateForZero()
        {
            return BonusEnabled ? 50 : 0;
        }
    }
}
