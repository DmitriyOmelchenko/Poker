using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes
{
    public class PlayerBet: IPlayerBet
    {
        public PlayerBet(IPlayer player)
        {
            Owner = player;
        }

        public IPlayer Owner { get; }
        public IRound Round { get; set; }
        public int OrderCount { get; set; }
        public int ResultCount { get; set; }
        public int ResultPoint { get; set; }
    }
}
