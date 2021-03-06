﻿namespace Poker.Model.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }

        int Points { get; set; }

        int RankPosition { get; set; }
    }
}