using System;
using System.Linq;
using PokerClasesesLibrary.Classes.Rounds;
using PokerClasesesLibrary.Enums;
using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes
{
    public class Game
    {
        public Game(IPlayer[] players)
        {
            Players = players;
            Rounds = CreateRounds(Players);
        }

        public IPlayer[] Players { get; }

        public BaseRound[] Rounds { get; private set; }

        private BaseRound[] CreateRounds(IPlayer[] players)
        {
            if (players == null)
                throw new ArgumentNullException();

            if (players.Length > 1)
                throw new ArgumentException("Count of players should be greater than one",
                    nameof(players));

            var cardsCount = (int) Math.Ceiling(36 / (double) players.Length);

            var simpleCount = cardsCount +
                (players.Length - 1) + cardsCount -1;

            var nonTrumpNumber = simpleCount - 1 + players.Length;

            var shadowNumber = nonTrumpNumber + players.Length;

            var goldNumber = shadowNumber + players.Length;

            var miseryNumber = goldNumber + players.Length;

            var roundCounts = (int)simpleCount + (Players.Length * 4);

            var rounds = new BaseRound[roundCounts];

            for (int i = 0; i < roundCounts; i++)
            {
                BaseRound round;

                var roundNumber = i + 1;

                if (i <= simpleCount)
                    round = CreateRound(RoundKind.Simple, roundNumber);
                else if (i <= nonTrumpNumber)
                    round = CreateRound(RoundKind.NonTrump, roundNumber);
                else if (i <= shadowNumber)
                    round = CreateRound(RoundKind.Shadow, roundNumber);
                else if (i <= goldNumber)
                    round = CreateRound(RoundKind.Gold, roundNumber);
                else
                    round = CreateRound(RoundKind.Misery, roundNumber);

                round.Bets = players.Select(p => new PlayerBet(p) {Round = round}).ToArray();

                rounds[i] = round;
            }

            return rounds;
        }

        private BaseRound CreateRound(RoundKind kind, int number)
        {
            switch (kind)
            {
                case RoundKind.Simple:
                    return new SimpleRound(number);
                case RoundKind.NonTrump:
                    return new NonTrumpRound(number);
                case RoundKind.Shadow:
                    return new ShadowRound(number);
                case RoundKind.Misery:
                    return new MiseryRound(number);
                case RoundKind.Gold:
                    return new GoldRound(number);
                default:
                    throw new ArgumentOutOfRangeException(nameof(kind), kind, null);
            }
        }
    }
}