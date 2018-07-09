namespace Poker.Model.Interfaces
{
    public interface IPlayerBet
    {
        IPlayer Owner { get; }

        int OrderCount { get; set; }

        int ResultCount { get; set; }

        int ResultPoint { get; set; }

        int Calculate(int rate);

        RoundKind Kind { get; }
    }
}