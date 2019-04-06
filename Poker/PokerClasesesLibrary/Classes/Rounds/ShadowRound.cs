using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes.Rounds
{
    public class ShadowRound: BaseRound
    {
        public ShadowRound(int number) : base(number,
            GameSettings.InstanceSettings.ShadowRatio, GameSettings.InstanceSettings.ShadowBetValue)
        {
        }

        public ShadowRound(int number, IPlayerBet[] bets) : base(number,
            GameSettings.InstanceSettings.ShadowRatio, GameSettings.InstanceSettings.ShadowBetValue, bets)
        {
        }
    }
}