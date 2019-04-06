using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Model.Interfaces;

namespace Poker.Model.Classes.Rounds
{
    public class SimpleRound : BaseRound 
    {
        public SimpleRound(int number) : base(number, 1, 10)
        {
        }

        public SimpleRound(int number, IPlayerBet[] bets) : base(number, 1, 10, bets)
        {
        }
    }
}
