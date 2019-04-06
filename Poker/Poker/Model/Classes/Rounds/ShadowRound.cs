using Poker.Model.Interfaces;

namespace Poker.Model.Classes.Rounds
{
    public class ShadowRound: BaseRound
    {
        public ShadowRound(int number) : base(number, 2, 20)
        {
        }

        public ShadowRound(int number, IPlayerBet[] bets) : base(number, 2, 20, bets)
        {
        }
    }
}