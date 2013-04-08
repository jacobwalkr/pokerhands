using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class StraightFlush : HandType
    {
        new public readonly int Rank = 9;
        public readonly List<int> ScoringValues;

        public StraightFlush(int _scoringValue)
        {
            this.ScoringValues = new List<int>(1);
            this.ScoringValues.Add(_scoringValue);
        }
    }
}
