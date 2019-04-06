using PokerClasesesLibrary.Enums;

namespace PokerClasesesLibrary.Interfaces
{
    public interface IRound
    {
        /// <summary>
        /// Round order
        /// </summary>
        int Number { get; }

        /// <summary>
        /// Coefficient for one bet
        /// </summary>
        int Rate { get; }

        int BetValue { get; set; }

        /// <summary>
        /// Player bets
        /// </summary>
        IPlayerBet[] Bets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Suit SuitCard { get; set; }
    }
}