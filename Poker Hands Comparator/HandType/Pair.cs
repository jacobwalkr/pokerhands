using System;

namespace PokerHands.HandType
{
    class Pair : HandType
    {
        new public readonly int Rank = 2;
        public int ScoringValue { get; private set; }

        public Pair(int _scoringValue)
        {
            this.ScoringValue = _scoringValue;
        }
    }
}
