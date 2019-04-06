using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes.Rounds
{
    public class SimpleRound : BaseRound 
    {
        public SimpleRound(int number) : base(number,
            1, GameSettings.InstanceSettings.SimpleBetValue)
        {
        }

        public SimpleRound(int number, IPlayerBet[] bets) : base(number,
            1, GameSettings.InstanceSettings.SimpleBetValue, bets)
        {
        }
    }
}
