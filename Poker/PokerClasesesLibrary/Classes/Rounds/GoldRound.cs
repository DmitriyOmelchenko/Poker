using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes.Rounds
{
    public class GoldRound: BaseRound
    {
        public GoldRound(int number) : base(number, 1, 10)
        {
        }

        public GoldRound(int number, IPlayerBet[] bets) : base(number, 1, 10, bets)
        {
        }

        protected override int CalculateForZero()
        {
            return BonusEnabled ? -50 : 0;
        }
    }
}
