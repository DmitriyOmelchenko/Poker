using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes.Rounds
{
    public class NonTrumpRound: BaseRound
    {
        public NonTrumpRound(int number) : base(number, 1,
            GameSettings.InstanceSettings.SimpleBetValue)
        {
        }

        public NonTrumpRound(int number, IPlayerBet[] bets) : base(number, 1,
            GameSettings.InstanceSettings.SimpleBetValue, bets)
        {
        }
    }
}
