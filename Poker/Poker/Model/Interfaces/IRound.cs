namespace Poker.Model.Interfaces
{
    public interface IRound
    {
        int Number { get; }

        int MaxCardCount { get; }

        int Rate { get; }

        IPlayerBet[] Bets { get; set; }

        Suit SuitCard { get; set; }
    }
}