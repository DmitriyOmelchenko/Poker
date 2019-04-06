using PokerClasesesLibrary.Enums;
using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes.Rounds
{
    public abstract class BaseRound: IRound
    {
        public static bool BonusEnabled { get; set; }

        protected BaseRound(int number, int rate, int betValue)
        {
            Number = number;
            Rate = rate;
            BetValue = betValue;
        }

        protected BaseRound(int number, int rate, int betValue, IPlayerBet[] bets): this(number, rate, betValue)
        {
            Bets = bets;
        }

        public int Number { get; }
        public int Rate { get; }
        public int BetValue { get; set; }

        public IPlayerBet[] Bets { get; set; }
        public Suit SuitCard { get; set; }

        public virtual int Calculate(IPlayerBet bet)
        {
            var point = 0;

            if (bet.ResultCount == 0 && bet.OrderCount == 0)
                point = CalculateForZero();
            else if (bet.ResultCount < bet.OrderCount)
                point = (bet.OrderCount - bet.ResultCount) * BetValue * Rate;
            else if (bet.ResultCount > bet.OrderCount)
                point = bet.ResultCount * Rate;

            bet.ResultPoint = point;

            return point;
        }

        protected virtual int CalculateForZero() => 5 * Rate;
    }
}
