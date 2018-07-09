using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Model.Interfaces;

namespace Poker.Model.Classes
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
