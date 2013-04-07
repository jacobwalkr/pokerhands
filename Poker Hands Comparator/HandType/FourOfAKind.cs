using System;

namespace PokerHands.HandType
{
    class FourOfAKind : HandType
    {
        new public readonly int Rank = 8;
        public int ScoringValue { get; private set; }

        public FourOfAKind(int _scoringValue)
        {
            this.ScoringValue = _scoringValue;
        }
    }
}
