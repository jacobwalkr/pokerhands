using System;

namespace PokerHands.HandType
{
    class FullHouse : HandType
    {
        new public readonly int Rank = 7;
        public int ScoringValue;

        public FullHouse(int _scoringValue)
        {
            this.ScoringValue = _scoringValue;
        }
    }
}
