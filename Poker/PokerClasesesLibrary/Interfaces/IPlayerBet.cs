namespace PokerClasesesLibrary.Interfaces
{
    public interface IPlayerBet
    {
        /// <summary>
        /// Owner of a bet
        /// </summary>
        IPlayer Owner { get; }

        /// <summary>
        /// Round that bet belongs to
        /// </summary>
        IRound Round { get; set; }

        /// <summary>
        /// Count of card offer by player
        /// </summary>
        int OrderCount { get; set; }

        /// <summary>
        /// Count of card at the and of round
        /// </summary>
        int ResultCount { get; set; }

        /// <summary>
        /// Number of point received by user per round
        /// </summary>
        int ResultPoint { get; set; }
    }
}