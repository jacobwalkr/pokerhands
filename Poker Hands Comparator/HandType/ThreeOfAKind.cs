using System;

namespace PokerHands.HandType
{
    class ThreeOfAKind : HandType
    {
        new public readonly int Rank = 4;
        public int ScoringValue { get; private set; }

        public ThreeOfAKind(int _scoringValue)
        {
            this.ScoringValue = _scoringValue;
        }
    }
}
