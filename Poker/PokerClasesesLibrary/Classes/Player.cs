using PokerClasesesLibrary.Interfaces;

namespace PokerClasesesLibrary.Classes
{
    public class Player: IPlayer
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public int Points { get; set; }
        public int RankPosition { get; set; }
    }
}
