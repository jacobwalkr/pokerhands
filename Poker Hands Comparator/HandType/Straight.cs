using System;

namespace PokerHands.HandType
{
    class Straight : HandType
    {
        new public readonly int Rank = 5;
        public int ScoringValue { get; private set; }

        public Straight(int _scoringValue)
        {
            this.ScoringValue = _scoringValue;
        }
    }
}
